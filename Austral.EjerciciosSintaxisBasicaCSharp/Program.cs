// =====================
// 1. Variables y Tipos
// =====================

// a) Declarar una variable con el nombre de una empresa y mostrarla por consola.
using System.Diagnostics.CodeAnalysis;

string nombreEmpresa = "Samsung";

// b) Declarar una variable con la cantidad de empleados y mostrarla por consola.

int cantidadEmpleados = 400;

// c) Declarar una variable decimal con el ingreso mensual estimado.

double ingresoMensual = 1000000.589;

// d) Mostrar por consola un mensaje que diga el nombre de la empresa, cantidad e empleados e ingreso.

Console.WriteLine($"La empresa {nombreEmpresa} cuenta con {cantidadEmpleados} de empleados, y tiene ingresos mensuales de {ingresoMensual}");


// ==============
// 2. Operadores
// ==============

// a) Declarar dos precios de productos y calcular el total de los dos con IVA.

int precioNetoProductoUno = 150;
int precioNetoProductoDos = 200;
double precioTotalProductoUno = precioNetoProductoUno + (precioNetoProductoUno * 0.21);
double precioTotalProductoDos = precioNetoProductoDos + (precioNetoProductoDos * 0.21);
Console.WriteLine($"Precio total del producto uno = {precioTotalProductoUno}; Precio total del producto dos = {precioTotalProductoDos}");

// b) En base a la siguiente variable -> int ingresoAnual = 1500;
//    Hacer otra variable que represente el ingreso mensual y mostrarla por consola.

int ingresoAnual = 1500;
int ingresoMensualDos = 1500 / 12;
Console.WriteLine($"Su ingreso mensual es {ingresoMensual}");

// c) Crear una variable que represente si el ingreso anual es mayor a 1000 o no.

bool ingresoMayorMil = ingresoAnual > 1000;
Console.WriteLine($"Su ingreso anual es mayor a 1000 = {ingresoMayorMil}");

// d) Calcular cuánto gana una empresa por mes si su ingreso anual es 1500
//    y tiene que pagar 12% de impuestos al estado.

double ingresoMensualNeto = (ingresoAnual - (ingresoAnual * 0.12)) / 12;
Console.WriteLine($"El ingreso mensual de Samsung descontado los impuestos del estado son {ingresoMensualNeto}");


// ==========================
// 3. Estructuras de Control
// ==========================

// a) En base a la cantidad de empleados de una empresa, mostrar por consola el tamaño de la misma:
//     - Si tiene 10 o menos empleados → "Startup"
//     - Si tiene Entre 11 y 50 → "Pyme"
//     - Si tiene más de 50 → "Big"

int numeroEmpleados = 60;

if (numeroEmpleados <= 10)
{
    Console.WriteLine("Startup");
}
else if (numeroEmpleados<50 && numeroEmpleados > 11)
{
    Console.WriteLine("Pyme");
}
else
{
    Console.WriteLine("Big");
}

// b) En base al monto de inversión de una empresa, clasificar la inversión como:
//     - Si es menor a 10,000 → "Baja"
//     - Si está entre 10,000 y 100,000 → "Media"
//     - Si es mayor a 100,000 → "Alta"

int montoInversion = 110000;

if (montoInversion < 10000)
{
    Console.WriteLine($"La inversión fue baja");
}
else if (montoInversion >= 10000 && montoInversion <= 100000)
{
    Console.WriteLine($"La inversión fue media");
}
else
{
    Console.WriteLine($"La inversión fue alta");
}

// c) Según el tipo de cliente ("mayorista" o "minorista"), mostrar el precio final de un producto con descuento si corresponde:
//     - Si es mayorista → 20% de descuento
//     - Si es minorista → 50% precio completo
//     - Si es cliente final -> 80% descuento 

// Opción con if 

string tipoCliente = "minorista";
int precioProducto = 150;

if (tipoCliente == "mayorista")
{
    Console.WriteLine(precioProducto - (precioProducto * 0.2));
}
else
{
    Console.WriteLine(precioProducto);
}

//Opción con switch

switch (tipoCliente)
{
    case "mayorista":
        Console.WriteLine("Tipo de cliente: mayorista. Se aplica 20% de descuento");
        Console.WriteLine(precioProducto - (precioProducto * 0.2));
        break;

    case "minorista":
        Console.WriteLine("Tipo de cliente: minorista. Se aplica 50% de descuento");
        Console.WriteLine(precioProducto - (precioProducto * 0.5));
        break;

    case "cliente final":
        Console.WriteLine("Tipo de cliente: cliente final. Se aplica 80% de descuento");
        Console.WriteLine(precioProducto - (precioProducto * 0.8));
        break;

    default: Console.WriteLine("Cliente no encontrado"); break;
}


// d) Una distribuidora tiene 20 unidades de cerveza en stock. Un cliente solicita 25 unidades.
//    Verificar si hay suficiente stock para concretar la venta:
//     - Si alcanza, mostrar por consola: "Venta confirmada. Cervezas en stock suficientes."
//     - Si no alcanza, mostrar: "No hay suficientes cervezas en stock. Faltan X unidades."
//       (donde X debe calcularse dinámicamente en base a las variables)

int stockCerveza = 20;
int solicitudCerveza = 25;

if (stockCerveza >= solicitudCerveza)
{
    Console.WriteLine("Venta confirmada. Cervaezas en stock suficiente.");
}
else
{
    int faltanCervezas = solicitudCerveza - stockCerveza;
    Console.WriteLine($"No hay suficientes cervaezas en stock. Faltan {faltanCervezas} unidades");
}


// ==========
// 4. Bucles
// ==========

// a) Mostrar los primeros 10 números naturales usando un for.

for (int i = 1; i<=10; i++)
{
    Console.WriteLine(i);
}

// b) Dado este array que representa las ventas de una empresa:
int[] ventasMensuales = { 1000, 1200, 950, 1100 };
//    Sumar las ventas mensuales con un foreach y mostrar el total por consola.

int ventas = 0;
foreach (int venta in ventasMensuales)
{
    ventas = ventas + venta;
} ;
Console.WriteLine(ventas);


// c) Hacer una cuenta regresiva del 5 al 1 con while.

int contador = 5;

while (contador != 0)
{
    Console.WriteLine(contador);
    contador--;
}

// d) Simular un login: pedir usuario hasta que ingrese "admin" con do-while. Crear variable de reintentos y al final de los intentos mostrar si pudo entrar o todos los intentos fueron fallidos

var usuario = "";
int contadorIntentos = 0;
bool primerIngreso = true;

do
{
    Console.WriteLine("Ingrese su nombre de usuario");
    usuario = Console.ReadLine();
    contadorIntentos++;
    if (primerIngreso == true)
    {
        Console.WriteLine("Usuario incorrecto. Por favor vuelva a loguearse");
        primerIngreso = false;
    }
} while (usuario != "admin" && contadorIntentos < 5);

if(contadorIntentos  == 5)
{
    Console.WriteLine("No se pudo loguear como admin dentro de los 5 intentos");
}
else
{

    Console.WriteLine("Pudo loguearse como admin");
}




// =============
// 5. Funciones
// =============

// a) Crear una función que reciba el ingreso mensual y devuelva el anual.
//    Llamar a la función y mostrar el resultado en consola.

// b) Crear una función que reciba una edad y devuelva si es mayor o menor de edad.
//    Llamar a la función y mostrar el resultado en consola.

// c) Crear una función que reciba el precio y el tipo de cliente y devuelva el precio final con o sin descuento.
//    Llamar a la función y mostrar el resultado en consola.


// ===================
// 6. Listas y arrays
// ===================

// a) Crear un array con nombres de 3 productos y mostrarlos por consola.

// b) Crear un array con los ingresos trimestrales (double) y calcular el total anual.

// c) Mostrar el producto más vendido de un array con cantidades vendidas.

// d) Crear una lista de precios y calcular el promedio.
//    Usar List<double> para practicar con listas.
