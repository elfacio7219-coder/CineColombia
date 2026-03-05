using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Cine Colombia");


var lista_cines = new List<Cines>();
lista_cines.Add(new Cines() { cineId = 1, nombre = "Cine Colombia Centro", direccion = "Calle 19 #3-16", telefono = "6012345678", email = "centro@cinecolombia.com" });
lista_cines.Add(new Cines() { cineId = 2, nombre = "Cine Colombia Norte",  direccion = "Av. 68 #100-10", telefono = "6019876543", email = "norte@cinecolombia.com" });

var lista_generos = new List<Generos>();
lista_generos.Add(new Generos() { generoId = 1, nombre = "Acción",           descripcion = "Películas de alto impacto visual y acción" });
lista_generos.Add(new Generos() { generoId = 2, nombre = "Animación",        descripcion = "Películas animadas para toda la familia" });
lista_generos.Add(new Generos() { generoId = 3, nombre = "Ciencia ficción",  descripcion = "Tramas basadas en ciencia y tecnología futurista" });

var lista_salas = new List<Salas>();
lista_salas.Add(new Salas() { salaId = 1, nombre = "Sala 1 - IMAX",   capacidad = 120, tipo = "IMAX",   cineId = 1 });
lista_salas.Add(new Salas() { salaId = 2, nombre = "Sala 2 - 3D",     capacidad = 80,  tipo = "3D",     cineId = 1 });
lista_salas.Add(new Salas() { salaId = 3, nombre = "Sala 3 - Normal", capacidad = 60,  tipo = "Normal", cineId = 2 });

var lista_asientos = new List<Asientos>();
lista_asientos.Add(new Asientos() { asientoId = 1, fila = "A", numero = 1, tipo = "Normal",       disponible = false, salaId = 1 });
lista_asientos.Add(new Asientos() { asientoId = 2, fila = "A", numero = 2, tipo = "Normal",       disponible = false, salaId = 2 });
lista_asientos.Add(new Asientos() { asientoId = 3, fila = "B", numero = 1, tipo = "VIP",          disponible = false, salaId = 1 });
lista_asientos.Add(new Asientos() { asientoId = 4, fila = "B", numero = 2, tipo = "Preferencial", disponible = true,  salaId = 2 });

var lista_empleados = new List<Empleados>();
lista_empleados.Add(new Empleados() { empleadoId = 1, nombre = "Luis",    apellido = "Ramirez", cargo = "Taquillero", salario = 1800000, fechaContratacion = new DateTime(2022, 5, 10), cineId = 1 });
lista_empleados.Add(new Empleados() { empleadoId = 2, nombre = "Andrea",  apellido = "Torres",  cargo = "Supervisor", salario = 2800000, fechaContratacion = new DateTime(2020, 3, 15), cineId = 1 });
lista_empleados.Add(new Empleados() { empleadoId = 3, nombre = "Ricardo", apellido = "Mora",    cargo = "Confiteria", salario = 1600000, fechaContratacion = new DateTime(2023, 8, 1),  cineId = 2 });

var lista_clientes = new List<Clientes>();
lista_clientes.Add(new Clientes() { clienteId = 1, nombre = "Juan",   apellido = "Perez", email = "juan@email.com",   telefono = "3001234567", fechaNacimiento = new DateTime(1995, 3, 10),  membresiaId = 1    });
lista_clientes.Add(new Clientes() { clienteId = 2, nombre = "Maria",  apellido = "Lopez", email = "maria@email.com",  telefono = "3109876543", fechaNacimiento = new DateTime(2008, 7, 22),  membresiaId = null });
lista_clientes.Add(new Clientes() { clienteId = 3, nombre = "Carlos", apellido = "Gomez", email = "carlos@email.com", telefono = "3205554433", fechaNacimiento = new DateTime(1958, 11, 5), membresiaId = 2    });

var lista_peliculas = new List<Peliculas>();
lista_peliculas.Add(new Peliculas() { peliculaId = 1, titulo = "Avengers",    director = "Russo",   duracion = 181, clasificacion = "PG-13", fechaEstreno = new DateTime(2019, 4, 26),  idioma = "Inglés",  generoId = 1 });
lista_peliculas.Add(new Peliculas() { peliculaId = 2, titulo = "El Rey Leon", director = "Favreau", duracion = 118, clasificacion = "G",     fechaEstreno = new DateTime(2019, 7, 19),  idioma = "Español", generoId = 2 });
lista_peliculas.Add(new Peliculas() { peliculaId = 3, titulo = "Inception",   director = "Nolan",   duracion = 148, clasificacion = "PG-13", fechaEstreno = new DateTime(2010, 7, 16),  idioma = "Inglés",  generoId = 3 });

var lista_funciones = new List<Funciones>();
lista_funciones.Add(new Funciones() { funcionId = 1, fechaHora = new DateTime(2026, 3, 10, 14, 0, 0), formato = "2D",   idioma = "Subtitulada", activa = true,  peliculaId = 1, salaId = 1, tarifaId = 1 });
lista_funciones.Add(new Funciones() { funcionId = 2, fechaHora = new DateTime(2026, 3, 10, 18, 0, 0), formato = "3D",   idioma = "Doblada",     activa = true,  peliculaId = 2, salaId = 2, tarifaId = 2 });
lista_funciones.Add(new Funciones() { funcionId = 3, fechaHora = new DateTime(2026, 3, 11, 20, 0, 0), formato = "IMAX", idioma = "Subtitulada", activa = false, peliculaId = 3, salaId = 1, tarifaId = 3 });

var lista_membresias = new List<Membresias>();
lista_membresias.Add(new Membresias() { membresiaId = 1, tipo = "Básica",  precioAnual = 120000, puntosAcumulados = 200,  fechaInicio = new DateTime(2025, 1, 1), fechaVencimiento = new DateTime(2026, 1, 1), activa = true  });
lista_membresias.Add(new Membresias() { membresiaId = 2, tipo = "Premium", precioAnual = 280000, puntosAcumulados = 1500, fechaInicio = new DateTime(2025, 6, 1), fechaVencimiento = new DateTime(2027, 6, 1), activa = true  });
lista_membresias.Add(new Membresias() { membresiaId = 3, tipo = "Gold",    precioAnual = 500000, puntosAcumulados = 0,    fechaInicio = new DateTime(2024, 1, 1), fechaVencimiento = new DateTime(2025, 1, 1), activa = false });

var lista_descuentos = new List<Descuentos>();
lista_descuentos.Add(new Descuentos() { descuentoId = 1, tipo = "Porcentaje", valor = 15,   condicion = "Estudiante",    promocionId = 1 });
lista_descuentos.Add(new Descuentos() { descuentoId = 2, tipo = "Monto fijo", valor = 5000, condicion = "Tercera edad",  promocionId = 1 });

var lista_tarifas = new List<Tarifas>();
lista_tarifas.Add(new Tarifas() { tarifaId = 1, nombre = "Normal semana",    precioBase = 18000, diaSemana = "Lunes-Viernes", horarioTipo = "Normal"   });
lista_tarifas.Add(new Tarifas() { tarifaId = 2, nombre = "Fin de semana 3D", precioBase = 22000, diaSemana = "Fin de semana", horarioTipo = "Normal"   });
lista_tarifas.Add(new Tarifas() { tarifaId = 3, nombre = "IMAX Nocturna",    precioBase = 30000, diaSemana = "Fin de semana", horarioTipo = "Nocturna" });

var lista_promociones = new List<Promociones>();
lista_promociones.Add(new Promociones() { promocionId = 1, nombre = "Martes de descuento", descripcion = "15% en todas las funciones los martes",    fechaInicio = new DateTime(2026, 1, 1),   fechaFin = new DateTime(2026, 12, 31), activa = true  });
lista_promociones.Add(new Promociones() { promocionId = 2, nombre = "Promo Estudiantes",   descripcion = "Descuento especial con carnet estudiantil", fechaInicio = new DateTime(2026, 2, 1),   fechaFin = new DateTime(2026, 6, 30),  activa = true  });
lista_promociones.Add(new Promociones() { promocionId = 3, nombre = "Black Friday Cine",   descripcion = "50% en funciones nocturnas",                fechaInicio = new DateTime(2025, 11, 28), fechaFin = new DateTime(2025, 11, 30), activa = false });

var lista_pagos = new List<Pagos>();
lista_pagos.Add(new Pagos() { pagoId = 1, monto = 36700, metodoPago = "Tarjeta débito", fechaPago = new DateTime(2026, 3, 9), estado = "Aprobado",  referencia = "REF-001-2026", promocionId = null });
lista_pagos.Add(new Pagos() { pagoId = 2, monto = 30000, metodoPago = "Efectivo",       fechaPago = new DateTime(2026, 3, 9), estado = "Aprobado",  referencia = "REF-002-2026", promocionId = null });
lista_pagos.Add(new Pagos() { pagoId = 3, monto = 18000, metodoPago = "PSE",            fechaPago = new DateTime(2026, 3, 8), estado = "Rechazado", referencia = "REF-003-2026", promocionId = 1    });

var lista_boletos = new List<Boletos>();
lista_boletos.Add(new Boletos() { boletoId = 1, codigoQR = "QR001", precioBase = 18000, precioFinal = 18000, fechaEmision = new DateTime(2026, 3, 9), usado = false, funcionId = 1, asientoId = 1, ventaId = 1 });
lista_boletos.Add(new Boletos() { boletoId = 2, codigoQR = "QR002", precioBase = 22000, precioFinal = 18700, fechaEmision = new DateTime(2026, 3, 9), usado = true,  funcionId = 2, asientoId = 2, descuentoId = 1, ventaId = 1 });
lista_boletos.Add(new Boletos() { boletoId = 3, codigoQR = "QR003", precioBase = 30000, precioFinal = 30000, fechaEmision = new DateTime(2026, 3, 9), usado = false, funcionId = 3, asientoId = 3, ventaId = 2 });

var lista_ventas = new List<Ventas>();
lista_ventas.Add(new Ventas() { ventaId = 1, fechaVenta = new DateTime(2026, 3, 9), total = 36700, canal = "Taquilla", clienteId = 1, empleadoId = 1, pagoId = 1 });
lista_ventas.Add(new Ventas() { ventaId = 2, fechaVenta = new DateTime(2026, 3, 9), total = 30000, canal = "Web",      clienteId = 3, empleadoId = 1, pagoId = 2 });

var lista_reservas = new List<Reservas>();
lista_reservas.Add(new Reservas() { reservaId = 1, fechaReserva = new DateTime(2026, 3, 8, 10, 0, 0), fechaExpiracion = new DateTime(2026, 3, 8, 10, 30, 0), estado = "Confirmada", clienteId = 1, funcionId = 1 });
lista_reservas.Add(new Reservas() { reservaId = 2, fechaReserva = new DateTime(2026, 3, 9, 15, 0, 0), fechaExpiracion = new DateTime(2026, 3, 9, 15, 30, 0), estado = "Pendiente",  clienteId = 2, funcionId = 2 });
lista_reservas.Add(new Reservas() { reservaId = 3, fechaReserva = new DateTime(2026, 3, 9, 18, 0, 0), fechaExpiracion = new DateTime(2026, 3, 9, 18, 30, 0), estado = "Cancelada",  clienteId = 3, funcionId = 3 });

var lista_productos = new List<Productos>();
lista_productos.Add(new Productos() { productoId = 1, nombre = "Crispetas grandes", descripcion = "Crispetas de mantequilla", precio = 12000, categoria = "Comida", disponible = true,  confiteriaId = 1 });
lista_productos.Add(new Productos() { productoId = 2, nombre = "Gaseosa 500ml",     descripcion = "Gaseosa fria",            precio = 6000,  categoria = "Bebida", disponible = true,  confiteriaId = 1 });
lista_productos.Add(new Productos() { productoId = 3, nombre = "Combo duo",         descripcion = "Crispetas + Gaseosa",     precio = 16000, categoria = "Combo",  disponible = false, confiteriaId = 1 });

var lista_inventarios = new List<Inventarios>();
lista_inventarios.Add(new Inventarios() { inventarioId = 1, productoId = 1, confiteriaId = 1, cantidadDisponible = 50, cantidadMinima = 10, ultimaActualizacion = DateTime.Now });
lista_inventarios.Add(new Inventarios() { inventarioId = 2, productoId = 2, confiteriaId = 1, cantidadDisponible = 8,  cantidadMinima = 10, ultimaActualizacion = DateTime.Now });
lista_inventarios.Add(new Inventarios() { inventarioId = 3, productoId = 3, confiteriaId = 1, cantidadDisponible = 0,  cantidadMinima = 5,  ultimaActualizacion = DateTime.Now });

var lista_confiterias = new List<Confiterias>();
lista_confiterias.Add(new Confiterias() { confiteriaId = 1, nombre = "Confitería Principal", ubicacion = "Planta baja - Entrada principal", cineId = 1 });
lista_confiterias.Add(new Confiterias() { confiteriaId = 2, nombre = "Confitería Norte",     ubicacion = "Segundo piso - Pasillo B",        cineId = 2 });

var lista_facturas = new List<Facturas>();
lista_facturas.Add(new Facturas() { facturaId = 1, numeroFactura = "FAC-2026-001", fechaEmision = new DateTime(2026, 3, 9), subtotal = 30840m, impuestos = 5860m,  total = 36700m, razonSocial = "Juan Perez",   nit = "1020304050-1", ventaId = 1 });
lista_facturas.Add(new Facturas() { facturaId = 2, numeroFactura = "FAC-2026-002", fechaEmision = new DateTime(2026, 3, 9), subtotal = 25210m, impuestos = 4790m,  total = 30000m, razonSocial = "Carlos Gomez", nit = "9876543210-2", ventaId = 2 });

// ── MOSTRAR TODAS LAS LISTAS 

Console.WriteLine("");
Console.WriteLine("--- CINES ---");
Console.WriteLine("ID | Nombre                    | Dirección            | Teléfono    | Email");
foreach (var c in lista_cines)
{
    Console.WriteLine(c.cineId + " | " +
        c.nombre + " | " +
        c.direccion + " | " +
        c.telefono + " | " +
        c.email);
}

Console.WriteLine("");
Console.WriteLine("--- GÉNEROS ---");
Console.WriteLine("ID | Nombre           | Descripción");
foreach (var g in lista_generos)
{
    Console.WriteLine(g.generoId + " | " +
        g.nombre + " | " +
        g.descripcion);
}

Console.WriteLine("");
Console.WriteLine("--- SALAS ---");
Console.WriteLine("ID | Nombre                | Capacidad | Tipo    | Cine ID");
foreach (var s in lista_salas)
{
    Console.WriteLine(s.salaId + " | " +
        s.nombre + " | " +
        s.capacidad + " | " +
        s.tipo + " | " +
        s.cineId);
}

Console.WriteLine("");
Console.WriteLine("--- ASIENTOS ---");
Console.WriteLine("ID | Fila | Número | Tipo          | Disponible | Sala ID");
foreach (var a in lista_asientos)
{
    Console.WriteLine(a.asientoId + " | " +
        a.fila + " | " +
        a.numero + " | " +
        a.tipo + " | " +
        a.disponible + " | " +
        a.salaId);
}

Console.WriteLine("");
Console.WriteLine("--- EMPLEADOS ---");
Console.WriteLine("ID | Nombre   | Apellido | Cargo        | Salario   | Contratación  | Cine ID");
foreach (var e in lista_empleados)
{
    Console.WriteLine(e.empleadoId + " | " +
        e.nombre + " | " +
        e.apellido + " | " +
        e.cargo + " | " +
        e.salario + " | " +
        e.fechaContratacion.ToShortDateString() + " | " +
        e.cineId);
}

Console.WriteLine("");
Console.WriteLine("--- CLIENTES ---");
Console.WriteLine("ID | Nombre  | Apellido | Email                | Teléfono    | Fecha Nac.  | Membresía");
foreach (var c in lista_clientes)
{
    Console.WriteLine(c.clienteId + " | " +
        c.nombre + " | " +
        c.apellido + " | " +
        c.email + " | " +
        c.telefono + " | " +
        c.fechaNacimiento.ToShortDateString() + " | " +
        (c.membresiaId.HasValue ? "Sí (ID " + c.membresiaId + ")" : "No"));
}

Console.WriteLine("");
Console.WriteLine("--- PELÍCULAS ---");
Console.WriteLine("ID | Título        | Director  | Duración     | Clasificación | Estreno      | Idioma");
foreach (var p in lista_peliculas)
{
    Console.WriteLine(p.peliculaId + " | " +
        p.titulo + " | " +
        p.director + " | " +
        p.DuracionFormateada() + " | " +
        p.clasificacion + " | " +
        p.fechaEstreno.ToShortDateString() + " | " +
        p.idioma);
}

Console.WriteLine("");
Console.WriteLine("--- FUNCIONES ---");
Console.WriteLine("ID | Fecha y Hora         | Formato | Idioma       | Película ID | Sala ID | Tarifa ID | Activa");
foreach (var f in lista_funciones)
{
    Console.WriteLine(f.funcionId + " | " +
        f.fechaHora + " | " +
        f.formato + " | " +
        f.idioma + " | " +
        f.peliculaId + " | " +
        f.salaId + " | " +
        f.tarifaId + " | " +
        f.activa);
}

Console.WriteLine("");
Console.WriteLine("--- MEMBRESÍAS ---");
Console.WriteLine("ID | Tipo    | Precio Anual | Puntos | Vencimiento  | Vigente");
foreach (var m in lista_membresias)
{
    Console.WriteLine(m.membresiaId + " | " +
        m.tipo + " | " +
        m.precioAnual + " | " +
        m.puntosAcumulados + " | " +
        m.fechaVencimiento.ToShortDateString() + " | " +
        m.EstaVigente());
}

Console.WriteLine("");
Console.WriteLine("--- DESCUENTOS ---");
Console.WriteLine("ID | Tipo        | Valor | Condición");
foreach (var d in lista_descuentos)
{
    Console.WriteLine(d.descuentoId + " | " +
        d.tipo + " | " +
        d.valor + " | " +
        d.condicion);
}

Console.WriteLine("");
Console.WriteLine("--- TARIFAS ---");
Console.WriteLine("ID | Nombre                | Precio Base | Día          | Horario");
foreach (var t in lista_tarifas)
{
    Console.WriteLine(t.tarifaId + " | " +
        t.nombre + " | " +
        t.precioBase + " | " +
        t.diaSemana + " | " +
        t.horarioTipo);
}

Console.WriteLine("");
Console.WriteLine("--- PROMOCIONES ---");
Console.WriteLine("ID | Nombre               | Inicio       | Fin          | Activa | Vigente");
foreach (var p in lista_promociones)
{
    Console.WriteLine(p.promocionId + " | " +
        p.nombre + " | " +
        p.fechaInicio.ToShortDateString() + " | " +
        p.fechaFin.ToShortDateString() + " | " +
        p.activa + " | " +
        p.EstaVigente());
}

Console.WriteLine("");
Console.WriteLine("--- PAGOS ---");
Console.WriteLine("ID | Monto   | Método           | Fecha        | Estado     | Referencia");
foreach (var p in lista_pagos)
{
    Console.WriteLine(p.pagoId + " | " +
        p.monto + " | " +
        p.metodoPago + " | " +
        p.fechaPago.ToShortDateString() + " | " +
        p.estado + " | " +
        p.referencia);
}

Console.WriteLine("");
Console.WriteLine("--- BOLETOS ---");
Console.WriteLine("ID | QR    | Precio Base | Precio Final | Emision      | Usado | Función ID");
foreach (var b in lista_boletos)
{
    Console.WriteLine(b.boletoId + " | " +
        b.codigoQR + " | " +
        b.precioBase + " | " +
        b.precioFinal + " | " +
        b.fechaEmision.ToShortDateString() + " | " +
        b.usado + " | " +
        b.funcionId);
}

Console.WriteLine("");
Console.WriteLine("--- VENTAS ---");
Console.WriteLine("ID | Código   | Fecha        | Canal    | Total  | Cliente ID");
foreach (var v in lista_ventas)
{
    Console.WriteLine(v.ventaId + " | " +
        "FA00" + v.ventaId + " | " +
        v.fechaVenta.ToShortDateString() + " | " +
        v.canal + " | " +
        v.total + " | " +
        v.clienteId);
}

Console.WriteLine("");
Console.WriteLine("--- RESERVAS ---");
Console.WriteLine("ID | Fecha Reserva        | Expiración           | Estado      | Cliente ID | Función ID");
foreach (var r in lista_reservas)
{
    Console.WriteLine(r.reservaId + " | " +
        r.fechaReserva + " | " +
        r.fechaExpiracion + " | " +
        r.estado + " | " +
        r.clienteId + " | " +
        r.funcionId);
}

Console.WriteLine("");
Console.WriteLine("--- PRODUCTOS CONFITERÍA ---");
Console.WriteLine("ID | Nombre              | Categoría | Precio  | Disponible");
foreach (var p in lista_productos)
{
    Console.WriteLine(p.productoId + " | " +
        p.nombre + " | " +
        p.categoria + " | " +
        p.precio + " | " +
        p.disponible);
}

Console.WriteLine("");
Console.WriteLine("--- INVENTARIO ---");
Console.WriteLine("ID | Producto ID | Disponible | Mínimo | Stock bajo");
foreach (var i in lista_inventarios)
{
    Console.WriteLine(i.inventarioId + " | " +
        i.productoId + " | " +
        i.cantidadDisponible + " | " +
        i.cantidadMinima + " | " +
        i.StockBajo());
}

Console.WriteLine("");
Console.WriteLine("--- CONFITERÍAS ---");
Console.WriteLine("ID | Nombre                    | Ubicación                         | Cine ID");
foreach (var c in lista_confiterias)
{
    Console.WriteLine(c.confiteriaId + " | " +
        c.nombre + " | " +
        c.ubicacion + " | " +
        c.cineId);
}

Console.WriteLine("");
Console.WriteLine("--- FACTURAS ---");
Console.WriteLine("ID | Número           | Emisión      | Subtotal  | Impuestos | Total   | Razón Social  | NIT");
foreach (var f in lista_facturas)
{
    Console.WriteLine(f.facturaId + " | " +
        f.numeroFactura + " | " +
        f.fechaEmision.ToShortDateString() + " | " +
        f.subtotal + " | " +
        f.impuestos + " | " +
        f.total + " | " +
        f.razonSocial + " | " +
        f.nit);
}

// ── CLASES ───────────────────────────────────────────────────

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
    public Membresias? membresia { get; set; }

    public List<Reservas> reservas { get; set; }
    public List<Ventas> ventas { get; set; }

    public int Edad()
    {
        int edad = DateTime.Today.Year - fechaNacimiento.Year;
        if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad)) edad--;
        return edad;
    }

    public bool EsMayorDeEdad()
    {
        return Edad() >= 18;
    }

    public bool EsTerceraEdad()
    {
        return Edad() >= 60;
    }

    public decimal TotalGastado()
    {
        return ventas?.Sum(v => v.CalcularTotal()) ?? 0;
    }
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
    public Cines? cine { get; set; }

    public List<Ventas> ventas { get; set; }
}

public class Salas
{
    public int salaId { get; set; }
    public string? nombre { get; set; }
    public int capacidad { get; set; }
    public string? tipo { get; set; }

    public int cineId { get; set; }
    public Cines? cine { get; set; }

    public List<Asientos> asientos { get; set; }
    public List<Funciones> funciones { get; set; }

    public int AsientosDisponibles()
    {
        return asientos?.Count(a => a.disponible) ?? 0;
    }

    public double PorcentajeOcupacion()
    {
        if (capacidad <= 0) return 0;
        int ocupados = capacidad - AsientosDisponibles();
        return (double)ocupados / capacidad * 100;
    }

    public List<Asientos> AsientosPorTipo(string tipo)
    {
        return asientos?.Where(a => a.tipo == tipo).ToList() ?? new List<Asientos>();
    }
}

public class Asientos
{
    public int asientoId { get; set; }
    public string? fila { get; set; }
    public int numero { get; set; }
    public string? tipo { get; set; }
    public bool disponible { get; set; }

    public int salaId { get; set; }
    public Salas? sala { get; set; }

    public List<Boletos> boletos { get; set; }
}

public class Peliculas
{
    public int peliculaId { get; set; }
    public string? titulo { get; set; }
    public string? director { get; set; }
    public int duracion { get; set; }
    public string? clasificacion { get; set; }
    public DateTime fechaEstreno { get; set; }
    public string? sinopsis { get; set; }
    public string? idioma { get; set; }

    public int generoId { get; set; }
    public Generos? genero { get; set; }

    public List<Funciones> funciones { get; set; }

    public string DuracionFormateada()
    {
        int horas = duracion / 60;
        int minutos = duracion % 60;
        if (horas > 0)
            return horas + " h " + minutos + " min";
        return minutos + " min";
    }

    public bool YaEstrenada()
    {
        return DateTime.Now >= fechaEstreno;
    }
}

public class Generos
{
    public int generoId { get; set; }
    public string? nombre { get; set; }
    public string? descripcion { get; set; }

    public List<Peliculas> peliculas { get; set; }
}

public class Funciones
{
    public int funcionId { get; set; }
    public DateTime fechaHora { get; set; }
    public string? formato { get; set; }
    public string? idioma { get; set; }
    public bool activa { get; set; }

    public int peliculaId { get; set; }
    public Peliculas? pelicula { get; set; }

    public int salaId { get; set; }
    public Salas? sala { get; set; }

    public int tarifaId { get; set; }
    public Tarifas? tarifa { get; set; }

    public List<Boletos> boletos { get; set; }
    public List<Reservas> reservas { get; set; }

    public int AsientosDisponibles(int capacidadSala)
    {
        return capacidadSala - (boletos?.Count ?? 0);
    }

    public double PorcentajeOcupacion(int capacidadSala)
    {
        if (capacidadSala <= 0) return 0;
        return (double)(boletos?.Count ?? 0) / capacidadSala * 100;
    }

    public bool YaComenzo()
    {
        return DateTime.Now >= fechaHora;
    }

    public decimal IngresosTotal()
    {
        return boletos?.Sum(b => b.CalcularPrecioFinal()) ?? 0;
    }
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
    public Funciones? funcion { get; set; }

    public int asientoId { get; set; }
    public Asientos? asiento { get; set; }

    public int? descuentoId { get; set; }
    public Descuentos? descuento { get; set; }

    public int? ventaId { get; set; }
    public Ventas? venta { get; set; }

    public decimal CalcularPrecioFinal()
    {
        if (descuento == null)
            return precioBase;

        if (descuento.tipo == "Porcentaje")
            return precioBase - (precioBase * descuento.valor / 100);

        if (descuento.tipo == "Monto fijo")
            return Math.Max(0, precioBase - descuento.valor);

        return precioBase;
    }

    public bool EstaVencido(int horasGracia = 2)
    {
        return !usado && DateTime.Now > fechaEmision.AddHours(horasGracia);
    }
}

public class Reservas
{
    public int reservaId { get; set; }
    public DateTime fechaReserva { get; set; }
    public DateTime fechaExpiracion { get; set; }
    public string? estado { get; set; }

    public int clienteId { get; set; }
    public Clientes? cliente { get; set; }

    public int funcionId { get; set; }
    public Funciones? funcion { get; set; }

    public List<Boletos> boletos { get; set; }

    public bool EstaVigente()
    {
        return estado == "Pendiente" && DateTime.Now <= fechaExpiracion;
    }

    public int CantidadBoletos()
    {
        return boletos?.Count ?? 0;
    }

    public decimal TotalEstimado()
    {
        return boletos?.Sum(b => b.precioBase) ?? 0;
    }
}

public class Ventas
{
    public int ventaId { get; set; }
    public DateTime fechaVenta { get; set; }
    public decimal total { get; set; }
    public string? canal { get; set; }

    public int clienteId { get; set; }
    public Clientes? cliente { get; set; }

    public int empleadoId { get; set; }
    public Empleados? empleado { get; set; }

    public int pagoId { get; set; }
    public Pagos? pago { get; set; }

    public List<Boletos> boletos { get; set; }
    public List<Productos> productos { get; set; }
    public Facturas? factura { get; set; }

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
    {
        return boletos?.Sum(b => b.CalcularPrecioFinal()) ?? 0;
    }

    public decimal SubtotalConfiteria()
    {
        return productos?.Sum(p => p.precio) ?? 0;
    }
}

public class Pagos
{
    public int pagoId { get; set; }
    public decimal monto { get; set; }
    public string? metodoPago { get; set; }
    public DateTime fechaPago { get; set; }
    public string? estado { get; set; }
    public string? referencia { get; set; }

    public int? promocionId { get; set; }
    public Promociones? promocion { get; set; }

    public List<Ventas> ventas { get; set; }

    public bool FueAprobado()
    {
        return estado == "Aprobado";
    }

    public decimal CalcularCambio(decimal montoEntregado)
    {
        if (metodoPago == "Efectivo")
            return Math.Max(0, montoEntregado - monto);
        return 0;
    }
}

public class Facturas
{
    public int facturaId { get; set; }
    public string? numeroFactura { get; set; }
    public DateTime fechaEmision { get; set; }
    public decimal subtotal { get; set; }
    public decimal impuestos { get; set; }
    public decimal total { get; set; }
    public string? razonSocial { get; set; }
    public string? nit { get; set; }

    public int ventaId { get; set; }
    public Ventas? venta { get; set; }

    public decimal CalcularImpuestos()
    {
        decimal tasaIva = 0.19m;
        return subtotal * tasaIva;
    }

    public decimal CalcularTotal()
    {
        return subtotal + CalcularImpuestos();
    }
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

    public bool EstaVigente()
    {
        return activa && DateTime.Now >= fechaInicio && DateTime.Now <= fechaFin;
    }

    public int DiasRestantes()
    {
        return (fechaFin - DateTime.Now).Days;
    }
}

public class Descuentos
{
    public int descuentoId { get; set; }
    public string? tipo { get; set; }
    public decimal valor { get; set; }
    public string? condicion { get; set; }

    public int promocionId { get; set; }
    public Promociones? promocion { get; set; }

    public List<Boletos> boletos { get; set; }

    public decimal AplicarA(decimal precio)
    {
        if (tipo == "Porcentaje")
            return precio - (precio * valor / 100);

        if (tipo == "Monto fijo")
            return Math.Max(0, precio - valor);

        return precio;
    }

    public decimal MontoAhorro(decimal precio)
    {
        return precio - AplicarA(precio);
    }
}

public class Tarifas
{
    public int tarifaId { get; set; }
    public string? nombre { get; set; }
    public decimal precioBase { get; set; }
    public string? diaSemana { get; set; }
    public string? horarioTipo { get; set; }

    public List<Funciones> funciones { get; set; }

    public bool AplicaAFuncion(DateTime fechaHora)
    {
        bool diaOk = VerificarDia(fechaHora.DayOfWeek);
        bool horarioOk = VerificarHorario(fechaHora.Hour);
        return diaOk && horarioOk;
    }

    private bool VerificarDia(DayOfWeek dia)
    {
        bool esFinDeSemana = dia == DayOfWeek.Saturday || dia == DayOfWeek.Sunday;
        if (diaSemana == "Lunes-Viernes") return !esFinDeSemana;
        if (diaSemana == "Fin de semana") return esFinDeSemana;
        return true;
    }

    private bool VerificarHorario(int hora)
    {
        if (horarioTipo == "Mañana")   return hora >= 10 && hora < 14;
        if (horarioTipo == "Normal")   return hora >= 14 && hora < 20;
        if (horarioTipo == "Nocturna") return hora >= 20 || hora < 10;
        return true;
    }

    public decimal PrecioConFormato(string formato)
    {
        if (formato == "3D")   return precioBase + (precioBase * 0.15m);
        if (formato == "IMAX") return precioBase + (precioBase * 0.30m);
        return precioBase;
    }
}

public class Confiterias
{
    public int confiteriaId { get; set; }
    public string? nombre { get; set; }
    public string? ubicacion { get; set; }

    public int cineId { get; set; }
    public Cines? cine { get; set; }

    public List<Productos> productos { get; set; }
    public List<Inventarios> inventarios { get; set; }
}

public class Productos
{
    public int productoId { get; set; }
    public string? nombre { get; set; }
    public string? descripcion { get; set; }
    public decimal precio { get; set; }
    public string? categoria { get; set; }
    public bool disponible { get; set; }

    public int confiteriaId { get; set; }
    public Confiterias? confiteria { get; set; }

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
    public Productos? producto { get; set; }

    public int confiteriaId { get; set; }
    public Confiterias? confiteria { get; set; }

    public bool StockBajo()
    {
        return cantidadDisponible <= cantidadMinima;
    }

    public int UnidadesParaReabastecer()
    {
        return Math.Max(0, cantidadMinima - cantidadDisponible);
    }

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
    public string? tipo { get; set; }
    public decimal precioAnual { get; set; }
    public int puntosAcumulados { get; set; }
    public DateTime fechaInicio { get; set; }
    public DateTime fechaVencimiento { get; set; }
    public bool activa { get; set; }

    public List<Clientes> clientes { get; set; }
    public List<Descuentos> descuentos { get; set; }

    public bool EstaVigente()
    {
        return activa && DateTime.Now <= fechaVencimiento;
    }

    public int DiasParaVencer()
    {
        return Math.Max(0, (fechaVencimiento - DateTime.Now).Days);
    }

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
    {
        return precioAnual / 12;
    }
}