## Explicación del código 
### DDD en .NET 7 con ChatGPT

[![video-youtube](__doc__/miniatura.png)](https://youtu.be/0CEcZ_Rdrd0)


> <img src="__doc__/PDF-ICON.png" alt= “presentacion” width="25" height="25"> [Descargar presentación](__doc__/DDD-Presentacion.pdf)

## Recomendaciones

> Si quiere validar que estas desarrollado basado en el dominio, tenga presente lo siguiente:

- **Priorice  desarrollar el dominio antes de cualquier otra capa**, recuerde el dominio define el negocio, ejemplo: Si diseñas un dominio/negocio de fútbol como mínimo tendrás entidades que representa la definición del deporte, como pudiera ser: gol, número de jugadores, se gana el partido, empata o se pierde, tipos de penalidad, diferencias entre jugadores(no es lo mismo un arquero a un defensa)

- **Evite caer en entidades anímicas**, una forma de saber que estamos diseñando basado al dominio es que nuestros objetos de entidad representa datos y funcionalidades , es decir si solo su entidad solo tiene get y set sin ninguna función que represente y/o restrinja dominio/negocio que se quiera representar, probablemente estás pensando en el objeto que se quiere guardar y no en modelar el dominio.

- **Separe subdominios adecuadamente**, esto también se le llama bounded context y se refiere que cada subdominio debe ser independiente del uno al otro, la excepción a la regla es que se puede llegar acuerdos de compartir algunos objetos de negocio (entidad, objeto de valor agregado) con estrategias como shared kernel entre otras, pero es la excepción y no regla en general.


- **No abuse de la capa de servicio del dominio**, ciertamente puede estar tentado a sacar la lógica de las entidades (lo que está mal porque estarías dejando la entidades anímicas) y exponerlas en el servicio. Lo que se debería procurar si no logras modelar en los objetos de dominio (entidades , objetos de valor y agregados) eso en particular lo podrias modelar en un servicio de dominio.


- **Los objetos de valor son más que un DTO inmutable**, estos objetos representan características que pueden ser usadas por una o más entidades, por ejemplo un color, estilo, dirección . Pero puede ser más que eso y encapsular las lógica de validación de esas mismas características , por ejemplo los colores admitidos son los primarios.



> Domain Driven Design Technical (DDD) en .NET 7 con ChatGPT

- 0:00 Presentación 
- 0:50 Funcionamiento del API | POSTAMN
- 2:25 Relación de capas | Arquitectura DDD 
- 3:29 Configurar Mapper | WebAPI
- 6:00 Configurar AppSettings en cualquier capa
- 8:50 Configurar inyección de dependencias entre capas
- 10:53 Capa Application | Arquitectura DDD 
- 16:15 Capa Domain | Arquitectura DDD 
-17:35 (TIPS) ValueObject vs entity | Arquitectura DDD 

😱 MINI SERIE API-CERVECERA 😱 
ChatGPT | Domain Driven Design | .NET 7

🍺 Diseño del negocio guiado con ChatGPT

https://youtu.be/P8aYyvec4v4 

🍺 Como usar ChatGPT para programar un proyecto real

https://youtu.be/8OwTDfZe2Bo

🍺 Código final con arquitectura DDD

https://youtu.be/0CEcZ_Rdrd0

😋 Notas de ayuda 😋

🍺 Instalar Mapper
> dotnet add package AutoMapper --version 12.0.1

🍺 Instalar Options para Configurar AppSettings

> dotnet add package Microsoft.Extensions.Options --version 7.0.1
