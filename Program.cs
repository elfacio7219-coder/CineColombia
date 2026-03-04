using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Cine Colombia");

public class Cines
{
    public int cineId { get; set; }
    public string? nombre { get; set; }
    public string? direccion { get; set; }
    public string? telefono { get; set; }
    public string? email { get; set; }

    public List<Salas> salas { get; set; }
    public List<Empleados> empleados { get; set; }
    public List<Confiterias> confiterias { get; set; }
}

public class Clientes
{
    public int clienteId { get; set; }
    public string? nombre { get; set; }
    public string? apellido { get; set; }
    public string? email { get; set; }
    public string? telefono { get; set; }
    public DateTime fechaNacimiento { get; set; }

    public int? membresiaId { get; set; }
    public Membresias membresia { get; set; }

    public List<Reservas> reservas { get; set; }
    public List<Ventas> ventas { get; set; }

    public int Edad()
    {
        var hoy = DateTime.Today;
        int edad = hoy.Year - fechaNacimiento.Year;
        if (fechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
        return edad;
    }

    public bool EsMayorDeEdad()
        => Edad() >= 18;

    public bool EsTerceraEdad()
        => Edad() >= 60;

    public decimal TotalGastado()
        => ventas?.Sum(v => v.CalcularTotal()) ?? 0;

    public int TotalCompras()
        => ventas?.Count ?? 0;
}

public class Empleados
{
    public int empleadoId { get; set; }
    public string? nombre { get; set; }
    public string? apellido { get; set; }
    public string? cargo { get; set; }
    public decimal salario { get; set; }
    public DateTime fechaContratacion { get; set; }

    public int cineId { get; set; }
    public Cines cine { get; set; }

    public List<Ventas> ventas { get; set; }
}

public class Salas
{
    public int salaId { get; set; }
    public string? nombre { get; set; }
    public int capacidad { get; set; }
    public string? tipo { get; set; } // 2D, 3D, IMAX

    public int cineId { get; set; }
    public Cines cine { get; set; }

    public List<Asientos> asientos { get; set; }
    public List<Funciones> funciones { get; set; }

    public int AsientosDisponibles()
        => asientos?.Count(a => a.disponible) ?? 0;

    public double PorcentajeOcupacion()
    {
        if (capacidad <= 0) return 0;
        int ocupados = capacidad - AsientosDisponibles();
        return (double)ocupados / capacidad * 100;
    }

    public List<Asientos> AsientosPorTipo(string tipo)
        => asientos?.Where(a => a.tipo == tipo).ToList() ?? new List<Asientos>();
}

public class Asientos
{
    public int asientoId { get; set; }
    public string? fila { get; set; }
    public int numero { get; set; }
    public string? tipo { get; set; } // Normal, VIP, Preferencial
    public bool disponible { get; set; }

    public int salaId { get; set; }
    public Salas sala { get; set; }

    public List<Boletos> boletos { get; set; }
}

public class Peliculas
{
    public int peliculaId { get; set; }
    public string? titulo { get; set; }
    public string? director { get; set; }
    public int duracion { get; set; } // en minutos
    public string? clasificacion { get; set; }
    public DateTime fechaEstreno { get; set; }
    public string? sinopsis { get; set; }
    public string? idioma { get; set; }

    public int generoId { get; set; }
    public Generos genero { get; set; }

    public List<Funciones> funciones { get; set; }

    public string DuracionFormateada()
    {
        int horas = duracion / 60;
        int minutos = duracion % 60;
        return horas > 0 ? $"{horas} h {minutos} min" : $"{minutos} min";
    }

    public bool YaEstrenada()
        => DateTime.Now >= fechaEstreno;

    public int DiasDesdEstreno()
        => (DateTime.Now - fechaEstreno).Days;
}

public class Generos
{
    public int generoId { get; set; }
    public string? nombre { get; set; }
    public string descripcion { get; set; }

    public List<Peliculas> peliculas { get; set; }
}

public class Funciones
{
    public int funcionId { get; set; }
    public DateTime fechaHora { get; set; }
    public string? formato { get; set; } // 2D, 3D, IMAX
    public string? idioma { get; set; } // Doblada, Subtitulada
    public bool activa { get; set; }

    public int peliculaId { get; set; }
    public Peliculas pelicula { get; set; }

    public int salaId { get; set; }
    public Salas sala { get; set; }

    public int tarifaId { get; set; }
    public Tarifas tarifa { get; set; }

    public List<Boletos> boletos { get; set; }
    public List<Reservas> reservas { get; set; }

    public double PorcentajeOcupacion(int capacidadSala)
    {
        if (capacidadSala <= 0) return 0;
        int boletosVendidos = boletos?.Count ?? 0;
        return (double)boletosVendidos / capacidadSala * 100;
    }

    public int AsientosDisponibles(int capacidadSala)
        => capacidadSala - (boletos?.Count ?? 0);

    public bool YaComenzo()
        => DateTime.Now >= fechaHora;

    public decimal IngresosTotal()
        => boletos?.Sum(b => b.CalcularPrecioFinal()) ?? 0;
}

public class Boletos
{
    public int boletoId { get; set; }
    public string? codigoQR { get; set; }
    public decimal precioBase { get; set; }
    public decimal precioFinal { get; set; }
    public DateTime fechaEmision { get; set; }
    public bool usado { get; set; }

    public int funcionId { get; set; }
    public Funciones funcion { get; set; }

    public int asientoId { get; set; }
    public Asientos asiento { get; set; }

    public int? descuentoId { get; set; }
    public Descuentos descuento { get; set; }

    public int? ventaId { get; set; }
    public Ventas venta { get; set; }

    public decimal CalcularPrecioFinal()
    {
        if (descuento == null)
            return precioBase;

        if (descuento.tipo == "Porcentaje")
            return precioBase - (precioBase * (descuento.valor / 100));

        if (descuento.tipo == "Monto fijo")
            return Math.Max(0, precioBase - descuento.valor);

        return precioBase;
    }

    public bool EstaVencido(int horasGracia = 2)
        => !usado && DateTime.Now > fechaEmision.AddHours(horasGracia);
}

public class Reservas
{
    public int reservaId { get; set; }
    public DateTime fechaReserva { get; set; }
    public DateTime fechaExpiracion { get; set; }
    public string? estado { get; set; } // Pendiente, Confirmada, Cancelada

    public int clienteId { get; set; }
    public Clientes cliente { get; set; }

    public int funcionId { get; set; }
    public Funciones funcion { get; set; }

    public List<Boletos> boletos { get; set; }

    public bool EstaVigente()
        => estado == "Pendiente" && DateTime.Now <= fechaExpiracion;

    public int CantidadBoletos()
        => boletos?.Count ?? 0;

    public decimal TotalEstimado()
        => boletos?.Sum(b => b.precioBase) ?? 0;
}

public class Ventas
{
    public int ventaId { get; set; }
    public DateTime fechaVenta { get; set; }
    public decimal total { get; set; }
    public string? canal { get; set; } // Taquilla, Web, App

    public int clienteId { get; set; }
    public Clientes cliente { get; set; }

    public int empleadoId { get; set; }
    public Empleados empleado { get; set; }

    public int pagoId { get; set; }
    public Pagos pago { get; set; }

    public List<Boletos> boletos { get; set; }
    public List<Productos> productos { get; set; }
    public Facturas factura { get; set; }

    public decimal CalcularTotal()
    {
        decimal subtotal = 0;

        if (boletos != null)
            foreach (var b in boletos)
                subtotal += b.CalcularPrecioFinal();

        if (productos != null)
            foreach (var p in productos)
                subtotal += p.precio;

        return subtotal;
    }

    public decimal SubtotalBoletos()
        => boletos?.Sum(b => b.CalcularPrecioFinal()) ?? 0;

    public decimal SubtotalConfiteria()
        => productos?.Sum(p => p.precio) ?? 0;

    public int CantidadBoletos()
        => boletos?.Count ?? 0;
}

public class Pagos
{
    public int pagoId { get; set; }
    public decimal monto { get; set; }
    public string? metodoPago { get; set; } // Efectivo, Tarjeta, Digital
    public DateTime fechaPago { get; set; }
    public string? estado { get; set; } // Aprobado, Rechazado, Pendiente
    public string? referencia { get; set; }

    public int? promocionId { get; set; }
    public Promociones promocion { get; set; }

    public List<Ventas> ventas { get; set; }

    public bool FueAprobado()
        => estado == "Aprobado";

    public decimal TotalVentas()
        => ventas?.Sum(v => v.CalcularTotal()) ?? 0;

    public decimal CalcularCambio(decimal montoEntregado)
        => metodoPago == "Efectivo" ? Math.Max(0, montoEntregado - monto) : 0;
}

public class Facturas
{
    private const decimal TASA_IVA = 0.19m;

    public int facturaId { get; set; }
    public string? numeroFactura { get; set; }
    public DateTime fechaEmision { get; set; }
    public decimal subtotal { get; set; }
    public decimal impuestos { get; set; }
    public decimal total { get; set; }
    public string? razonSocial { get; set; }
    public string? nit { get; set; }

    public int ventaId { get; set; }
    public Ventas venta { get; set; }

    public decimal CalcularImpuestos()
        => subtotal * TASA_IVA;

    public decimal CalcularTotal()
        => subtotal + CalcularImpuestos();

    public static string GenerarNumeroFactura(int ventaId)
        => $"FC-{DateTime.Now:yyyyMMdd}-{ventaId:D6}";
}

public class Promociones
{
    public int promocionId { get; set; }
    public string? nombre { get; set; }
    public string? descripcion { get; set; }
    public DateTime fechaInicio { get; set; }
    public DateTime fechaFin { get; set; }
    public bool activa { get; set; }

    public List<Descuentos> descuentos { get; set; }
    public List<Pagos> pagos { get; set; }

    public bool EstaVigente(DateTime? fecha = null)
    {
        var ahora = fecha ?? DateTime.Now;
        return activa && ahora >= fechaInicio && ahora <= fechaFin;
    }

    public int DiasRestantes()
        => (fechaFin - DateTime.Now).Days;
}

public class Descuentos
{
    public int descuentoId { get; set; }
    public string? tipo { get; set; } // Porcentaje, Monto fijo
    public decimal valor { get; set; }
    public string? condicion { get; set; } // Estudiante, Tercera edad, etc.

    public int promocionId { get; set; }
    public Promociones promocion { get; set; }

    public List<Boletos> boletos { get; set; }

    public decimal AplicarA(decimal precio)
    {
        return tipo switch
        {
            "Porcentaje" => precio - (precio * valor / 100),
            "Monto fijo" => Math.Max(0, precio - valor),
            _            => precio
        };
    }

    public decimal MontoAhorro(decimal precioBase)
        => precioBase - AplicarA(precioBase);
}

public class Tarifas
{
    public int tarifaId { get; set; }
    public string? nombre { get; set; }
    public decimal precioBase { get; set; }
    public string? diaSemana { get; set; } // Lunes-Viernes, Fin de semana
    public string? horarioTipo { get; set; } // Mañana, Normal, Nocturna

    public List<Funciones> funciones { get; set; }

    public bool AplicaAFuncion(DateTime fechaHora)
        => VerificarDia(fechaHora.DayOfWeek) && VerificarHorario(fechaHora.Hour);

    private bool VerificarDia(DayOfWeek dia)
    {
        bool esFinDeSemana = dia == DayOfWeek.Saturday || dia == DayOfWeek.Sunday;
        return diaSemana switch
        {
            "Lunes-Viernes" => !esFinDeSemana,
            "Fin de semana" => esFinDeSemana,
            _               => true
        };
    }

    private bool VerificarHorario(int hora)
    {
        return horarioTipo switch
        {
            "Mañana"   => hora >= 10 && hora < 14,
            "Normal"   => hora >= 14 && hora < 20,
            "Nocturna" => hora >= 20 || hora < 10,
            _          => true
        };
    }

    public decimal PrecioConFormato(string formato)
    {
        decimal recargo = formato switch
        {
            "3D"   => precioBase * 0.15m,
            "IMAX" => precioBase * 0.30m,
            _      => 0
        };
        return precioBase + recargo;
    }
}

public class Confiterias
{
    public int confiteriaId { get; set; }
    public string? nombre { get; set; }
    public string? ubicacion { get; set; }

    public int cineId { get; set; }
    public Cines cine { get; set; }

    public List<Productos> productos { get; set; }
    public List<Inventarios> inventarios { get; set; }
}

public class Productos
{
    public int productoId { get; set; }
    public string? nombre { get; set; }
    public string? descripcion { get; set; }
    public decimal precio { get; set; }
    public string? categoria { get; set; } // Bebida, Comida, Combo
    public bool disponible { get; set; }

    public int confiteriaId { get; set; }
    public Confiterias confiteria { get; set; }

    public List<Inventarios> inventarios { get; set; }
    public List<Ventas> ventas { get; set; }
}

public class Inventarios
{
    public int inventarioId { get; set; }
    public int cantidadDisponible { get; set; }
    public int cantidadMinima { get; set; }
    public DateTime ultimaActualizacion { get; set; }

    public int productoId { get; set; }
    public Productos producto { get; set; }

    public int confiteriaId { get; set; }
    public Confiterias confiteria { get; set; }

    public bool StockBajo()
        => cantidadDisponible <= cantidadMinima;

    public int UnidadesParaReabastecer()
        => Math.Max(0, cantidadMinima - cantidadDisponible);

    public bool DescontarStock(int cantidad)
    {
        if (cantidad <= 0 || cantidad > cantidadDisponible) return false;
        cantidadDisponible -= cantidad;
        ultimaActualizacion = DateTime.Now;
        return true;
    }

    public void ReponerStock(int cantidad)
    {
        if (cantidad > 0)
        {
            cantidadDisponible += cantidad;
            ultimaActualizacion = DateTime.Now;
        }
    }
}

public class Membresias
{
    public int membresiaId { get; set; }
    public string? tipo { get; set; } // Básica, Premium, Gold
    public decimal precioAnual { get; set; }
    public int puntosAcumulados { get; set; }
    public DateTime fechaInicio { get; set; }
    public DateTime fechaVencimiento { get; set; }
    public bool activa { get; set; }

    public List<Clientes> clientes { get; set; }
    public List<Descuentos> descuentos { get; set; }

    public bool EstaVigente()
        => activa && DateTime.Now <= fechaVencimiento;

    public int DiasParaVencer()
        => Math.Max(0, (fechaVencimiento - DateTime.Now).Days);

    public void AgregarPuntos(int puntos)
    {
        if (puntos > 0)
            puntosAcumulados += puntos;
    }

    public bool CanjearPuntos(int puntos)
    {
        if (puntos <= 0 || puntos > puntosAcumulados) return false;
        puntosAcumulados -= puntos;
        return true;
    }

    public decimal PrecioMensual()
        => precioAnual / 12;
}