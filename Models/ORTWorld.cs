public static class ORTWorld
{
    public static List<string> ListaDestinos { get; private set; } = new List<string> { "Miami", "Madrid", "Barcelona", "Orlando", "NY", "Los Angeles", "Cancun", "Punta Cana", "Chicago", "Ciudad de Mexico" };
    public static List<string> ListaHoteles { get; private set; } = new List<string> { "HardRock.jpg", "Hilton.jpg", "Sheraton.jpg", "Endless Summer.jpg", "The Langham.jpg", "Best Western.jpg", "Gran Palladium.jpg", "Bahia Principe.jpg", "Holiday Inn.jpg", "Hyatt.jpg" };
    public static List<string> ListaAereos { get; private set; } = new List<string> { "American Airlines.jpg", "Iberia.jpg", "Level.jpg", "JetBlue.jpg", "Delta.jpg", "United Airlines.jpg", "Aerolineas Argentinas.jpg", "Copa.jpg", "Air Canada.jpg", "AeroMexico.jpg" };
    public static List<string> ListaExcursiones { get; private set; } = new List<string> { "Sawgrass.jpg", "Bernabeu.jpg", "Sagrada Familia.jpg", "Parques.jpg", "Central Park.jpg", "Cartel.jpg", "Delfines.jpg", "Isla Saona.jpg", "Museo Holocausto.jpg", "Palacio de bellas artes.jpg" };
    public static Dictionary<string, Paquete> Paquetes { get; private set; }

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        if (!Paquetes.ContainsKey(destinoSeleccionado))
        {
            Paquetes.Add(destinoSeleccionado, paquete);

            return true;
        }
        else
        {

            return false;
        }
    }

}