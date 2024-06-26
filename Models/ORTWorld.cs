public static class ORTWorld
{
    public static List<string> ListaDestinos { get; private set; } = new List<string> { "Miami", "Madrid", "Barcelona", "Orlando", "NY", "Los Angeles", "Cancun", "Punta Cana", "Chicago", "Ciudad de Mexico" };
    public static List<string> ListaHoteles { get; private set; } = new List<string> { "HardRock", "Hilton", "Sheraton", "Endless Summer", "The Langham", "Best Western", "Gran Palladium", "Bahia Principe", "Holiday Inn", "Hyatt" };
    public static List<string> ListaAereos { get; private set; } = new List<string> { "American Airlines", "Iberia", "Level", "JetBlue", "Delta", "United Airlines", "Aerolineas Argentinas", "Copa", "Air Canada", "AeroMexico" };
    public static List<string> ListaExcursiones { get; private set; } = new List<string> { "Sawgrass", "Bernabeu", "Sagrada Familia", "Parques", "Central Park", "Cartel", "Delfines", "Isla Saona", "Museo Holocausto", "Palacio de Bellas Artes" };
    public static Dictionary<string, Paquete> Paquetes { get; private set; } = new Dictionary<string, Paquete>();

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