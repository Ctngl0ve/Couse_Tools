namespace Задание14_2
{
    public delegate void DeviceStateChanged(string message);
    internal class Program
    {

        static void Main(string[] args)
        {
            SmartHomeSystem smartHomeSystem = new SmartHomeSystem();

            smartHomeSystem.DeviceStateChanged += X;
            //smartHomeSystem.DeviceStateChanged += (message) =>
            //{
            //    Console.WriteLine($"{DateTime.Now:HH:mm:ss} | {message}"); //или тут прикол в этой части? (комментарий ниже был первым)
            //};
            smartHomeSystem.TurnOnLight();
            smartHomeSystem.TurnOffLight();
            smartHomeSystem.SetTemperature(23);
            smartHomeSystem.LockDoor();
            smartHomeSystem.UnlockDoor();
            Console.ReadKey();
        }
        static void X(string massange)
        {
            Console.WriteLine($"{DateTime.Now:HH:mm:ss} | {massange}");
        }
    }

    class SmartHomeSystem
    {
        public event DeviceStateChanged DeviceStateChanged;
        public string Name { get; set; }
        //public bool OnOff { get; set; }
        public void TurnOnLight()
        {
            Name = "Light";
            DeviceStateChanged?.Invoke($"{Name}: Включен"); //Это тоже самое что и cw(($"{Name}: Включен")); без события, так в чем смысл то?
        }
        public void TurnOffLight()
        {
            Name = "Light";
            DeviceStateChanged?.Invoke($"{Name}: Выключен");
        }
        public void SetTemperature(int newTemp)
        {
            Name = "Thermostat";
            DeviceStateChanged?.Invoke($"{Name}: Температура изменена на {newTemp}°C");
        }
        public void LockDoor()
        {
            Name = "Door";
            DeviceStateChanged?.Invoke($"{Name}: Заблокирована");
        }
        public void UnlockDoor()
        {
            Name = "Door";
            DeviceStateChanged?.Invoke($"{Name}: Разблокирована");
        }

    }
}
