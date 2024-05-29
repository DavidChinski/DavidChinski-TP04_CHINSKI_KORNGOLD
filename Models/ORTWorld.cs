class ORTWorld
{
    public static List<string> ListaDestinos { get; private set; } = new List<string> {"Miami", "Madrid", "Barcelona", "Orlando", "NY", "Los Angeles", "Cancun", "Punta Cana", "Chicago", "Ciudad de Mexico"};
    public static List<string> ListaHoteles { get; private set; } = new List<string> {"Hard Rock", "Hilton", "Sheraton", "Endless Summer", "The Langham", "Best Western", "Gran Palladium", "Bahia Principe", "Holiday Inn", "Hyatt"};
    public static List<string> ListaAereos { get; private set; } = new List<string> {"American Airlines", "Iberia", "Level", "JetBlue", "Delta", "United Airlines", "Aerolineas Argentinas", "Copa", "Air Canada", "AeroMexico"};
    public static List<string> ListaExcursiones { get; private set; } = new List<string> {"Sawgrass", "Bernabeu", "Sagrada Familia", "Parques", "Central Park", "Cartel", "Delfines", "Isla Saona", "Museo Holocausto", "Palacio de bellas artes"};
    public static Dictionary<string, Paquete> Paquetes { get; private set; }

    static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        


    }


}