using Xunit;

public class MisTests
{
    private Comida_Rapida _comidaRapida = new Comida_Rapida();

    // Test 1: Comprobar si el envío sale gratis (mínimo 15€)
    public void Test_Envio_Gratis()
    {
        Assert.True(_comidaRapida.EnvioGratis(15.0));  
        Assert.True(_comidaRapida.EnvioGratis(32.5)); 
        Assert.False(_comidaRapida.EnvioGratis(12.0)); 
    }

     // Test 2: Comprobar el funcionamiento del cupón "PROFE10"
    public void Test_Cupon_Descuento()
    {
        Assert.Equal(20, _comidaRapida.AplicarCupon(30, "PROFE10"));    
        Assert.Equal(30, _comidaRapida.AplicarCupon(30, "CUPONFALSO")); 
        Assert.Equal(0, _comidaRapida.AplicarCupon(10, "PROFE10"));     
    }

  // Test 3: Comprobar suplemento de queso extra (+1.50€)
    public void Test_Precio_Queso_Extra()
    {
        Assert.Equal(11.50, _comidaRapida.ConQuesoExtra(10.0));
        Assert.Equal(1.50, _comidaRapida.ConQuesoExtra(0.0));
        Assert.NotEqual(10.0, _comidaRapida.ConQuesoExtra(10.0));
    }

// Test 4: Validar textos del estado del pedido
    public void Test_Estado_Pedido()
    {
        Assert.True(_comidaRapida.EstadoValido("En cocina"));
        Assert.False(_comidaRapida.EstadoValido(""));   
        Assert.False(_comidaRapida.EstadoValido(null)); 
    }

// Test 5: Comprobar el horario de apertura (12h a 23h)
    public void Test_Horario_Apertura()
    {
        Assert.True(_comidaRapida.EstaAbierto(14));  
        Assert.True(_comidaRapida.EstaAbierto(23));  
        Assert.False(_comidaRapida.EstaAbierto(4));  
    }
}
