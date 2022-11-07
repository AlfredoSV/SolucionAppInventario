# "Solución que contiene el proyecto WebApi y MVC, ambos en .net Core 3.1"

#Pasos para compilar.

1.- Clonar el repositorio

2.- Abrir dos ventanas de la misma solución en Visual Studio (Uno para la WebApi y otra para el poryecto MVC)

3.- En una ventana seleccionar como proyecto de Inicio el proyecto WebApiInventario y correr seleccionando 
como servidor IIS Express. (Importante: Validar que el proyecto este corriendo sobre el puerto 44347,
en dado caso que ya se ecuentre ocupado ese puerto, se pocederá a cambiarlo en el proyecto AppInventario en 
el archivo appsettings.json -> Propiedad URLApi)

4.- En la otra ventana seleccionar como proyecto de Inicio el proyecto AppInventario y correr seleccionando 
como servidor IIS Express. (Importante: Validar que el proyecto WebApiInventario ya se encuentre ejecutandose para
poder realizar la comunicación entre los dos proyectos)

