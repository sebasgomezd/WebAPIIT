# WebAPIAccionaIT

Para Poder probar la API con Postman se agrego un archivo: AccionaITAPI.postman_collection.json
para importarlo.

Nota: El usuario valido para este Ejercicio es 
{ usuario:"admin",
password:"1234"
}


Se utilizo log4net para logguear en .txt

Del paquete Nuget se instaló NewtonJson.

Comentarios:
# No se especificó cual estructura devolveria el login de usuario, asi que se tomó que devuelva IHttpActionResult
# Para la parte de provincias se tomó una estructura que sea entendible al usuario: string[] { "latitud:xxxxx", "longitud:xxxx"}


