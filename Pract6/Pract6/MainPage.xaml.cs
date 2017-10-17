using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace Pract6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SQLiteAsyncConnection database;
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("Practica.db");
            database = new SQLiteAsyncConnection(db);
            database.CreateTableAsync<TESHDatos>().Wait();
            var elemento = new TESHDatos
            {
                Matricula = "13090418",
                Nombre = "Brenda Itzel",
                Apellido = "Villanueva",
                Direccion = "Cerrada Rio Bravo",
                Telefono = "5517479951",
                Carrera = "Ing. Sistemas Computacionales",
                Semestre = "9",
                Correo = "bren.villanueva10@gmail.com",
                GitHub = "BrendaVillanueva"

            };
            database.InsertAsync(elemento);


        }
    }
}
