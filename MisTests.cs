using Xunit;

public class MisTests
{
    private readonly TelepizzaVirtual _telepi = new TelepizzaVirtual();

    [Fact] // Test 1: Comprobar si el envío sale gratis (mínimo 15€)
    public void Test_Envio_Gratis()
    {
        Assert.True(_telepi.EnvioGratis(15.0));  // Límite exacto
        Assert.True(_telepi.EnvioGratis(32.5));  // De sobra
        Assert.False(_telepi.EnvioGratis(12.0)); // No llega
    }

    [Fact] // Test 2: Comprobar el funcionamiento del cupón "PROFE10"
    public void Test_Cupon_Descuento()
    {
        Assert.Equal(20, _telepi.AplicarCupon(30, "PROFE10"));    // Cupón correcto
        Assert.Equal(30, _telepi.AplicarCupon(30, "CUPONFALSO")); // Cupón erróneo
        Assert.Equal(0, _telepi.AplicarCupon(10, "PROFE10"));     // Límite cero
    }

    [Fact] // Test 3: Comprobar suplemento de queso extra (+1.50€)
    public void Test_Precio_Queso_Extra()
    {
        Assert.Equal(11.50, _telepi.ConQuesoExtra(10.0));
        Assert.Equal(1.50, _telepi.ConQuesoExtra(0.0));
        Assert.NotEqual(10.0, _telepi.ConQuesoExtra(10.0));
    }

    [Fact] // Test 4: Validar textos del estado del pedido
    public void Test_Estado_Pedido()
    {
        Assert.True(_telepi.EstadoValido("En cocina"));
        Assert.False(_telepi.EstadoValido(""));   // Caso vacío
        Assert.False(_telepi.EstadoValido(null)); // Caso nulo
    }

    [Fact] // Test 5: Comprobar el horario de apertura (12h a 23h)
    public void Test_Horario_Apertura()
    {
        Assert.True(_telepi.EstaAbierto(14));  // Abierto
        Assert.True(_telepi.EstaAbierto(23));  // Límite de cierre
        Assert.False(_telepi.EstaAbierto(4));  // Cerrado de madrugada
    }
}