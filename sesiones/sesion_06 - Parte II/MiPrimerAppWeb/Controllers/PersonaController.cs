using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiPrimerAppWeb.Models;

namespace MiPrimerAppWeb.Controllers
{
    public class PersonaController : Controller
    {
        private string API = "https://localhost:44314/api/";

        public IActionResult Index()
        {
            PersonaViewModel p = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(API);

                var responseTask = client.GetAsync("Persona");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Models.PersonaDTO[]>();
                    readTask.Wait();

                    var personas = readTask.Result;

                    p = new PersonaViewModel();
                    p.personas = new List<PersonaDTO>();
                    p.personas = personas.ToList();


                }


            }
            return View(p);
        }


        public IActionResult Buscar(string id)
        {
            PersonaViewModel p = null;

            if (id != null & id != string.Empty)
            {


                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(API);

                    var responseTask = client.GetAsync("Persona/" + id);
                    responseTask.Wait();

                    var result = responseTask.Result;

                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<Models.PersonaDTO>();
                        readTask.Wait();

                        var persona = readTask.Result;

                        p = new PersonaViewModel();
                        p.personas = new List<PersonaDTO>();
                        p.persona = persona;
                    }
                }
            }
            else
            {
                p = new PersonaViewModel();
            }

            return View(p);
        }

        public IActionResult Crear(string nombre, string ApPaterno, string ApMaterno, int Edad)
        {
            PersonaDTO persona = null;

            if (HttpContext.Request.Method == "POST")
            {
                if (nombre != null && ApPaterno != null && ApMaterno != null && Edad > 0)
                {
                    PersonaViewModel p = null;
                    persona = new PersonaDTO();
                    persona.ApMaterno = ApMaterno;
                    persona.ApPaterno = ApPaterno;
                    persona.Nombre = nombre;
                    persona.Edad = Edad;

                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(API);

                        var responseTask = client.PostAsJsonAsync("Persona", persona);
                        responseTask.Wait();

                        var result = responseTask.Result;

                        if (result.IsSuccessStatusCode)
                        {
                            var readTask = result.Content.ReadAsStringAsync();
                            readTask.Wait();

                            var resultJson = readTask.Result;

                            return RedirectToAction("Index");

                        }
                    }


                }
            }

            return View();
        }


        public IActionResult Eliminar(string id)
        {
            if (id != null & id != string.Empty)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(API);
                    var responseTask = client.DeleteAsync("Persona/" + id);
                    responseTask.Wait();

                    var result = responseTask.Result;

                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsStringAsync();
                        readTask.Wait();

                        var resultJson = readTask.Result;

                    }

                }

            }

            return RedirectToAction("Index");

        }

        public IActionResult Actualizar(PersonaDTO persona)
        {
            if (HttpContext.Request.Method == "POST")
            {

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(API);
                    var responseTask = client.PutAsJsonAsync("Persona/" + persona.Id, persona);
                    responseTask.Wait();

                    var result = responseTask.Result;

                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsStringAsync();
                        readTask.Wait();

                        var resultJson = readTask.Result;

                        return RedirectToAction("Index");

                    }


                }

            }

            return View();

        }
    }
}
