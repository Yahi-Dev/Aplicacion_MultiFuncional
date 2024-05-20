Resumen de los requerimientos funcionales para una aplicación de gestión de usuarios y login

La imagen muestra una descripción de los requerimientos funcionales para una aplicación de gestión de usuarios y login. La aplicación debe cumplir con los siguientes requisitos:

Registro de usuarios y login:

Para poder acceder a la aplicación y usarla, la persona debe registrarse previamente y una vez registrado, iniciar sesión.
Los datos de registro deben guardarse en un archivo JSON y ser leídos del mismo para el inicio de sesión.
Funcionalidades una vez registrado:

Sumadora.
Debe permitir ingresar dos valores y realizar cualquiera de las 4 operaciones aritméticas básicas (a demanda del usuario) y mostrar el resultado.
Convertidora de divisas.
Debe permitir convertir valores a Pesos. Dolares y Euros a demanda del usuario.
Convertidora de temperatura.
Debe permitir convertir un valor de una unidad de temperatura (Celcius, Farenheit, Kelvin) a otra, a demanda del usuario.
Log de operaciones:

Por cada operación realizada, la aplicación guardará automáticamente un log (registro) en un archivo TXT con los siguientes datos:
Usuario que hizo la operación
Cuál operación realizó (indicando la unidad o divisa involucrada)
Valores de entrada
Valores de salida
Fecha y hora de la operación
Requerimientos de diseño:

Implementar el patrón de diseño Singleton para que el log de operaciones sea manejado desde una clase de la cual solo pueda usarse una instancia.
Aplicar el principio SRP
