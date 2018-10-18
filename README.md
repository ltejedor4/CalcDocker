# CalcDocker
Web api que permite realizar las 4 operaciones basicas

1.	Clonar repositorio
2.	Abrir consola de comandos
3.	Navegar hasta la carpeta de la solución ejemplo: cd c:\users\desktop\CalcApi\CalcApi que es donde se encuentra el archivo Dockerfile.
4.	Ejecutar comando dotnet run, para validar que la aplicación si funcione.
5.	Compilar imagen: ejecutar Docker build -t apicalc/core ., se descargan las imágenes necesarias.
6.	Una vez creada la imagen ejecutar el contenedor docker run – p 80:5000 apicalc/core
7.	Desde postman realizar peticiones get
curl -X GET \
  http://localhost/api/Calculator/sum/1/2/3/4 \
  -H 'Postman-Token: cf8eb73a-a183-422b-8dce-b14ce506f2e2' \
  -H 'cache-control: no-cache'
Especificar las operaciones a realizar: los números deben ir separados por el carácter /, si la peticion no es correcta se obtendra un 400
sum: sumar n números
res: restar 2 números
mul: multiplicar n números
div: dividir 2 números.

