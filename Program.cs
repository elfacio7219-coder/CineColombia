using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Cine Colombia");

public class Cine
{
    public int cineId { get; set; }
    public string nombre { get; set; }
    public string direccion { get; set; }
    public string telefono { get; set; }
    public string email { get; set; }

    // Listas
    public List<Sala> salas { get; set; }
    public List<Empleado> empleados { get; set; }
    public List<Confiteria> confiterias { get; set; }
}

public class Cliente
{
    public int clienteId { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string email { get; set; }
    public string telefono { get; set; }
    public DateTime fechaNacimiento { get; set; }

    // FK
    public int? membresiaId { get; set; }
    public Membresia membresia { get; set; }

    // Listas
    public List<Reserva> reservas { get; set; }
    public List<Venta> ventas { get; set; }
}

public class Empleado
{
    public int empleadoId { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string cargo { get; set; }
    public decimal salario { get; set; }
    public DateTime fechaContratacion { get; set; }

    // FK
    public int cineId { get; set; }
    public Cine cine { get; set; }

    // Listas
    public List<Venta> ventas { get; set; }
}

public class Sala
{
    public int salaId { get; set; }
    public string nombre { get; set; }
    public int capacidad { get; set; }
    public string tipo { get; set; } // 2D, 3D, IMAX

    // FK
    public int cineId { get; set; }
    public Cine cine { get; set; }

    // Listas
    public List<Asiento> asientos { get; set; }
    public List<Funcion> funciones { get; set; }
}

public class Asiento
{
    public int asientoId { get; set; }
    public string fila { get; set; }
    public int numero { get; set; }
    public string tipo { get; set; } // Normal, VIP, Preferencial
    public bool disponible { get; set; }

    // FK
    public int salaId { get; set; }
    public Sala sala { get; set; }

    // Listas
    public List<Boleto> boletos { get; set; }
}

public class Pelicula
{
    public int peliculaId { get; set; }
    public string titulo { get; set; }
    public string director { get; set; }
    public int duracion { get; set; } // en minutos
    public string clasificacion { get; set; }
    public DateTime fechaEstreno { get; set; }
    public string sinopsis { get; set; }
    public string idioma { get; set; }

    // FK
    public int generoId { get; set; }
    public Genero genero { get; set; }

    // Listas
    public List<Funcion> funciones { get; set; }
}

public class Genero
{
    public int generoId { get; set; }
    public string nombre { get; set; }
    public string descripcion { get; set; }

    // Listas
    public List<Pelicula> peliculas { get; set; }
}

public class Funcion
{
    public int funcionId { get; set; }
    public DateTime fechaHora { get; set; }
    public string formato { get; set; } // 2D, 3D, IMAX
    public string idioma { get; set; } // Doblada, Subtitulada
    public bool activa { get; set; }

    // FK
    public int peliculaId { get; set; }
    public Pelicula pelicula { get; set; }

    public int salaId { get; set; }
    public Sala sala { get; set; }

    public int tarifaId { get; set; }
    public Tarifa tarifa { get; set; }

    // Listas
    public List<Boleto> boletos { get; set; }
    public List<Reserva> reservas { get; set; }
}

public class Boleto
{
    public int boletoId { get; set; }
    public string codigoQR { get; set; }
    public decimal precioFinal { get; set; }
    public DateTime fechaEmision { get; set; }
    public bool usado { get; set; }

    // FK
    public int funcionId { get; set; }
    public Funcion funcion { get; set; }

    public int asientoId { get; set; }
    public Asiento asiento { get; set; }

    public int? descuentoId { get; set; }
    public Descuento descuento { get; set; }

    public int? ventaId { get; set; }
    public Venta venta { get; set; }
}

public class Reserva
{
    public int reservaId { get; set; }
    public DateTime fechaReserva { get; set; }
    public DateTime fechaExpiracion { get; set; }
    public string estado { get; set; } // Pendiente, Confirmada, Cancelada

    // FK
    public int clienteId { get; set; }
    public Cliente cliente { get; set; }

    public int funcionId { get; set; }
    public Funcion funcion { get; set; }

    // Listas
    public List<Boleto> boletos { get; set; }
}

public class Venta
{
    public int ventaId { get; set; }
    public DateTime fechaVenta { get; set; }
    public decimal total { get; set; }
    public string canal { get; set; } // Taquilla, Web, App

    // FK
    public int clienteId { get; set; }
    public Cliente cliente { get; set; }

    public int empleadoId { get; set; }
    public Empleado empleado { get; set; }

    public int pagoId { get; set; }
    public Pago pago { get; set; }

    // Listas
    public List<Boleto> boletos { get; set; }
    public List<Producto> productos { get; set; }
    public Factura factura { get; set; }
}

public class Pago
{
    public int pagoId { get; set; }
    public decimal monto { get; set; }
    public string metodoPago { get; set; } // Efectivo, Tarjeta, Digital
    public DateTime fechaPago { get; set; }
    public string estado { get; set; } // Aprobado, Rechazado, Pendiente
    public string referencia { get; set; }

    // FK
    public int? promocionId { get; set; }
    public Promocion promocion { get; set; }

    // Listas
    public List<Venta> ventas { get; set; }
}

public class Factura
{
    public int facturaId { get; set; }
    public string numeroFactura { get; set; }
    public DateTime fechaEmision { get; set; }
    public decimal subtotal { get; set; }
    public decimal impuestos { get; set; }
    public decimal total { get; set; }
    public string razonSocial { get; set; }
    public string nit { get; set; }

    // FK
    public int ventaId { get; set; }
    public Venta venta { get; set; }
}

public class Promocion
{
    public int promocionId { get; set; }
    public string nombre { get; set; }
    public string descripcion { get; set; }
    public DateTime fechaInicio { get; set; }
    public DateTime fechaFin { get; set; }
    public bool activa { get; set; }

    // Listas
    public List<Descuento> descuentos { get; set; }
    public List<Pago> pagos { get; set; }
}

public class Descuento
{
    public int descuentoId { get; set; }
    public string tipo { get; set; } // Porcentaje, Monto fijo
    public decimal valor { get; set; }
    public string condicion { get; set; } // Estudiante, Tercera edad, etc.

    // FK
    public int promocionId { get; set; }
    public Promocion promocion { get; set; }

    // Listas
    public List<Boleto> boletos { get; set; }
}

public class Tarifa
{
    public int tarifaId { get; set; }
    public string nombre { get; set; }
    public decimal precioBase { get; set; }
    public string diaSemana { get; set; } // Lunes-Viernes, Fin de semana
    public string horarioTipo { get; set; } // Matiné, Normal, Nocturna

    // Listas
    public List<Funcion> funciones { get; set; }
}

public class Confiteria
{
    public int confiteriaId { get; set; }
    public string nombre { get; set; }
    public string ubicacion { get; set; }

    // FK
    public int cineId { get; set; }
    public Cine cine { get; set; }

    // Listas
    public List<Producto> productos { get; set; }
    public List<Inventario> inventarios { get; set; }
}

public class Producto
{
    public int productoId { get; set; }
    public string nombre { get; set; }
    public string descripcion { get; set; }
    public decimal precio { get; set; }
    public string categoria { get; set; } // Bebida, Comida, Combo
    public bool disponible { get; set; }

    // FK
    public int confiteriaId { get; set; }
    public Confiteria confiteria { get; set; }

    // Listas
    public List<Inventario> inventarios { get; set; }
    public List<Venta> ventas { get; set; }
}

public class Inventario
{
    public int inventarioId { get; set; }
    public int cantidadDisponible { get; set; }
    public int cantidadMinima { get; set; }
    public DateTime ultimaActualizacion { get; set; }

    // FK
    public int productoId { get; set; }
    public Producto producto { get; set; }

    public int confiteriaId { get; set; }
    public Confiteria confiteria { get; set; }
}

public class Membresia
{
    public int membresiaId { get; set; }
    public string tipo { get; set; } // Básica, Premium, Gold
    public decimal precioAnual { get; set; }
    public int puntosAcumulados { get; set; }
    public DateTime fechaInicio { get; set; }
    public DateTime fechaVencimiento { get; set; }
    public bool activa { get; set; }

    // Listas
    public List<Cliente> clientes { get; set; }
    public List<Descuento> descuentos { get; set; }
}