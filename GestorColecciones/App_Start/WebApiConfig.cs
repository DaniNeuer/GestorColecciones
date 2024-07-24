// ************************************************************************
// Practica 11
// Josue Chicaiza - Daniel Tapia
// Fecha de realización: 17/07/2024
// Fecha de entrega: 24/07/2024
// Resultados:
// * Se desarrollaron los modelos Roca y Fosil con las propiedades necesarias, incluyendo validaciones
// mediante anotaciones de datos.
// * Las propiedades de los modelos fueron validadas correctamente para asegurar que los datos ingresados
// cumplan con los requisitos establecidos (por ejemplo, rangos de peso y campos obligatorios).
//
// * POST: Crear una Roca
// {
//      "ID": 8,
//      "Nombre": "Piedra p2",
//      "Tipo": "Caliza",
//      "Ubicacion": "30S, 4E",
//      "Peso": 10.0,
//      "Descripcion": "Roca"
// }
// * El resultado es coherente con lo establecido en el código, ya que se creó una nueva roca con los
// datos proporcionados. Las propiedades adicionales Descripcion y Peso están en sus valores
// 
// * GET: Obtener todas las Rocas
// // [
//     {
//         "ID": 1,
//         "Nombre": "Piedra p11",
//         "Tipo": "Caliza",
//         "Ubicacion": "51N, 34O",
//         "Peso": 0.0,
//         "Descripcion": ""
//     },
//     {
//         "ID": 2,
//         "Nombre": "Piedra p2",
//         "Tipo": "Caliza",
//         "Ubicacion": "30S, 4E",
//         "Peso": 0.0,
//         "Descripcion": ""
//     },
//     {
//         "ID": 3,
//         "Nombre": "Granito",
//         "Tipo": "Ígnea",
//         "Ubicacion": "Brasil",
//         "Peso": 50.0,
//         "Descripcion": "Roca ígnea de granito"
//     },
//     {
//         "ID": 4,
//         "Nombre": "Mármol",
//         "Tipo": "Metamórfica",
//         "Ubicacion": "Italia",
//         "Peso": 30.0,
//         "Descripcion": "Roca metamórfica de mármol"
//     },
//     {
//         "ID": 5,
//         "Nombre": "Pizarra",
//         "Tipo": "Metamórfica",
//         "Ubicacion": "España",
//         "Peso": 20.0,
//         "Descripcion": "Roca metamórfica de pizarra"
//     },
//     {
//         "ID": 6,
//         "Nombre": "Basalto",
//         "Tipo": "Ígnea",
//         "Ubicacion": "Islandia",
//         "Peso": 70.0,
//         "Descripcion": "Roca ígnea de basalto"
//     },
//     {
//         "ID": 7,
//         "Nombre": "Arenisca",
//         "Tipo": "Sedimentaria",
//         "Ubicacion": "Australia",
//         "Peso": 40.0,
//         "Descripcion": "Roca sedimentaria de arenisca"
//     },
//     {
//         "ID": 8,
//         "Nombre": "Piedra p2",
//         "Tipo": "Caliza",
//         "Ubicacion": "30S, 4E",
//         "Peso": 10.0,
//         "Descripcion": "Roca"
//     }
// ]
// El resultado es coherente con lo esperado, mostrando una lista de todas las rocas creadas,
// incluyendo sus propiedades adicionales con valores predeterminados.
//
// * GET: Obtener una Roca específica por ID
// [
//     {
//         "ID": 8,
//         "Nombre": "Piedra p2",
//         "Tipo": "Caliza",
//         "Ubicacion": "30S, 4E",
//         "Peso": 10.0,
//         "Descripcion": "Roca"
//     }
// ]
// El resultado es coherente con lo esperado, mostrando los detalles de la roca con ID 1.
//
// * PUT: Actualizar una Roca existente
// El resultado es coherente con lo establecido en el código, indicando que la roca fue
// actualizada correctamente. No se devuelve contenido en el cuerpo de la respuesta, lo
// cual es estándar para operaciones de actualización exitosas.
// 
// * DELETE: Eliminar todas las Rocas
// Este resultado indica que no está permitido eliminar todas las rocas de una vez utilizando
// esta ruta. La implementación del controlador no permite esta operación.
// 
// * Eliminar una Roca específica por ID
// [
//     {
//         "ID": 8,
//         "Nombre": "Piedra p2",
//         "Tipo": "Caliza",
//         "Ubicacion": "30S, 4E",
//         "Peso": 10.0,
//         "Descripcion": "Roca"
//     }
// ]
// El resultado es coherente con lo esperado, mostrando los detalles de la roca eliminada.
// La roca con ID 1 fue eliminada correctamente de la base de datos.
//
// * Pruebas con FosilesController
// Se realizaron las mismas pruebas que con RocasController y todos los resultados fueron coherentes con las expectativas.
// 
// * Pruebas desde el Explorador Web
// Las URL respondieron correctamente mostrando las listas de fósiles y rocas.
// * Las URL respondieron correctamente mostrando los detalles del fósil y roca con ID 1.
// * El funcionamiento de las rutas es correcto y coherente con las implementaciones en el código.
//
// Conclusiones:
// * La práctica demostró que ASP.NET Web API y Entity Framework pueden integrarse de manera
// efectiva para crear aplicaciones robustas de gestión de datos. La configuración adecuada
// y la instalación de Entity Framework permiten manejar operaciones CRUD con validaciones
// completas en un entorno de desarrollo controlado.
// * Implementar anotaciones de datos en los modelos asegura que los datos sean validados antes
// de ser almacenados en la base de datos. Esto es crucial para mantener la integridad y
// consistencia de los datos, como se evidenció en la validación de las propiedades de Roca y Fosil.
// * La estructura modular del código, con controladores específicos para cada tipo de entidad
// (Roca y Fosil), facilita el mantenimiento y la escalabilidad del proyecto. Esto también permite
// una gestión más clara y organizada de las rutas y acciones dentro de la API.
// * La práctica destacó la importancia de utilizar herramientas como Postman para probar y depurar
// servicios web. Las pruebas realizadas con Postman confirmaron la correcta implementación de los
// métodos HTTP y la coherencia de las respuestas de la API, lo cual es esencial para asegurar la
// funcionalidad del sistema antes de su despliegue.
//
// Recomendaciones:
// * Implementar pruebas automatizadas para los controladores y métodos de la API puede mejorar
// la eficiencia del proceso de validación y asegurar que futuras modificaciones no introduzcan
// errores. Herramientas como NUnit o xUnit pueden ser útiles para este propósito.
// * Considerar la optimización de la base de datos mediante índices y consultas optimizadas puede
// mejorar significativamente el rendimiento de la aplicación, especialmente cuando se trabaja con
// grandes volúmenes de datos.
// * Para mejorar la funcionalidad del gestor de colecciones, se podrían añadir características
// adicionales como autenticación y autorización de usuarios, funcionalidades de búsqueda avanzada
// y la integración de un frontend más amigable para el usuario final. Esto haría la aplicación más
// robusta y útil para los usuarios finales.
// ************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace GestorColecciones
{
    // Clase de configuración de Web API
    public static class WebApiConfig
    {
        // Método para registrar la configuración de Web API
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de Web API

            // Habilita el uso de rutas basadas en atributos en los controladores
            config.MapHttpAttributeRoutes();

            // Configura la ruta por defecto para los controladores de Web API
            config.Routes.MapHttpRoute(
                name: "DefaultApi", // Nombre de la ruta
                routeTemplate: "api/{controller}/{id}", // Plantilla de la ruta
                defaults: new { id = RouteParameter.Optional } // Parámetro opcional 'id'
            );
        }
    }
}
