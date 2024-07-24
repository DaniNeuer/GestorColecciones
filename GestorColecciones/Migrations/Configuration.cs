namespace GestorColecciones.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GestorColecciones.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<GestorColecciones.DAL.GestorColeccion>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GestorColecciones.DAL.GestorColeccion context)
        {
            context.Fosiles.AddOrUpdate(
                f => f.Nombre,
                new Fosil { Nombre = "Tyrannosaurus Rex", Especie = "Tyrannosaurus", Periodo = "Cretácico", Peso = 0.5, Ubicacion = "USA", Descripcion = "Fósil de un Tyrannosaurus Rex" },
                new Fosil { Nombre = "Triceratops", Especie = "Triceratops", Periodo = "Cretácico", Peso = 0.7, Ubicacion = "Canada", Descripcion = "Fósil de un Triceratops" },
                new Fosil { Nombre = "Stegosaurus", Especie = "Stegosaurus", Periodo = "Jurásico", Peso = 0.6, Ubicacion = "USA", Descripcion = "Fósil de un Stegosaurus" },
                new Fosil { Nombre = "Velociraptor", Especie = "Velociraptor", Periodo = "Cretácico", Peso = 0.3, Ubicacion = "Mongolia", Descripcion = "Fósil de un Velociraptor" },
                new Fosil { Nombre = "Brachiosaurus", Especie = "Brachiosaurus", Periodo = "Jurásico", Peso = 0.8, Ubicacion = "Tanzania", Descripcion = "Fósil de un Brachiosaurus" }
            );

            context.Rocas.AddOrUpdate(
                r => r.Nombre,
                new Roca { Nombre = "Granito", Tipo = "Ígnea", Peso = 50.0, Ubicacion = "Brasil", Descripcion = "Roca ígnea de granito" },
                new Roca { Nombre = "Mármol", Tipo = "Metamórfica", Peso = 30.0, Ubicacion = "Italia", Descripcion = "Roca metamórfica de mármol" },
                new Roca { Nombre = "Pizarra", Tipo = "Metamórfica", Peso = 20.0, Ubicacion = "España", Descripcion = "Roca metamórfica de pizarra" },
                new Roca { Nombre = "Basalto", Tipo = "Ígnea", Peso = 70.0, Ubicacion = "Islandia", Descripcion = "Roca ígnea de basalto" },
                new Roca { Nombre = "Arenisca", Tipo = "Sedimentaria", Peso = 40.0, Ubicacion = "Australia", Descripcion = "Roca sedimentaria de arenisca" }
            );

            context.SaveChanges();
        }
    }
}
