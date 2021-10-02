using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UCP.App.Persistencia;

using UCP.App.Dominio;

namespace UCP.APP.Frontend.Pages
{
    public class ProfesoresModel : PageModel
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new UCP.App.Persistencia.AppContext());
        public IEnumerable<Profesor> Profesores{get;set;}
        public Profesor profesor{get;set;}
        public void OnGet()
        {

            Profesores = _repoProfesor.GetAllProfesores();
            profesor = Profesores.ElementAt(1);
            Console.WriteLine(profesor.id);
        }
    }
}