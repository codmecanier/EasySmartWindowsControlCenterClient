using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using 智能平台总控端.Models.Mapping;

namespace 智能平台总控端.Models
{
    public partial class EasySmartDataBaseContext : DbContext
    {
        static EasySmartDataBaseContext()
        {
            Database.SetInitializer<EasySmartDataBaseContext>(null);
        }

        public EasySmartDataBaseContext()
            : base("Name=EasySmartDataBaseContext")
        {
        }

        public DbSet<Alarm> Alarms { get; set; }
        public DbSet<AlarmToSensor> AlarmToSensors { get; set; }
        public DbSet<AlarmToUser> AlarmToUsers { get; set; }
        public DbSet<Control> Controls { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<DeviceToPerform> DeviceToPerforms { get; set; }
        public DbSet<DeviceToRemoteButton> DeviceToRemoteButtons { get; set; }
        public DbSet<DeviceToSensor> DeviceToSensors { get; set; }
        public DbSet<DeviceToUser> DeviceToUsers { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<FloorToRoom> FloorToRooms { get; set; }
        public DbSet<Mode> Modes { get; set; }
        public DbSet<ModeToPerform> ModeToPerforms { get; set; }
        public DbSet<ModeToTimer> ModeToTimers { get; set; }
        public DbSet<Perform> Performs { get; set; }
        public DbSet<PerformToControl> PerformToControls { get; set; }
        public DbSet<RemoteButton> RemoteButtons { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomToDevice> RoomToDevices { get; set; }
        public DbSet<RoomToRemote> RoomToRemotes { get; set; }
        public DbSet<RoomToUser> RoomToUsers { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<SensorToControl> SensorToControls { get; set; }
        public DbSet<Timer> Timers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPerformPower> UserPerformPowers { get; set; }
        public DbSet<UserSensorPower> UserSensorPowers { get; set; }
        public DbSet<UserToFloor> UserToFloors { get; set; }
        public DbSet<UserToMode> UserToModes { get; set; }
        public DbSet<UserToTimer> UserToTimers { get; set; }
        public DbSet<AlarmView> AlarmViews { get; set; }
        public DbSet<DeviceInformationView> DeviceInformationViews { get; set; }
        public DbSet<DevicePerformView> DevicePerformViews { get; set; }
        public DbSet<DeviceRoomView> DeviceRoomViews { get; set; }
        public DbSet<DeviceSensorView> DeviceSensorViews { get; set; }
        public DbSet<FloorView> FloorViews { get; set; }
        public DbSet<ModeInfoView> ModeInfoViews { get; set; }
        public DbSet<RoomDeviceView> RoomDeviceViews { get; set; }
        public DbSet<RoomView> RoomViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlarmMap());
            modelBuilder.Configurations.Add(new AlarmToSensorMap());
            modelBuilder.Configurations.Add(new AlarmToUserMap());
            modelBuilder.Configurations.Add(new ControlMap());
            modelBuilder.Configurations.Add(new DeviceMap());
            modelBuilder.Configurations.Add(new DeviceToPerformMap());
            modelBuilder.Configurations.Add(new DeviceToRemoteButtonMap());
            modelBuilder.Configurations.Add(new DeviceToSensorMap());
            modelBuilder.Configurations.Add(new DeviceToUserMap());
            modelBuilder.Configurations.Add(new FloorMap());
            modelBuilder.Configurations.Add(new FloorToRoomMap());
            modelBuilder.Configurations.Add(new ModeMap());
            modelBuilder.Configurations.Add(new ModeToPerformMap());
            modelBuilder.Configurations.Add(new ModeToTimerMap());
            modelBuilder.Configurations.Add(new PerformMap());
            modelBuilder.Configurations.Add(new PerformToControlMap());
            modelBuilder.Configurations.Add(new RemoteButtonMap());
            modelBuilder.Configurations.Add(new RoomMap());
            modelBuilder.Configurations.Add(new RoomToDeviceMap());
            modelBuilder.Configurations.Add(new RoomToRemoteMap());
            modelBuilder.Configurations.Add(new RoomToUserMap());
            modelBuilder.Configurations.Add(new SensorMap());
            modelBuilder.Configurations.Add(new SensorToControlMap());
            modelBuilder.Configurations.Add(new TimerMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserPerformPowerMap());
            modelBuilder.Configurations.Add(new UserSensorPowerMap());
            modelBuilder.Configurations.Add(new UserToFloorMap());
            modelBuilder.Configurations.Add(new UserToModeMap());
            modelBuilder.Configurations.Add(new UserToTimerMap());
            modelBuilder.Configurations.Add(new AlarmViewMap());
            modelBuilder.Configurations.Add(new DeviceInformationViewMap());
            modelBuilder.Configurations.Add(new DevicePerformViewMap());
            modelBuilder.Configurations.Add(new DeviceRoomViewMap());
            modelBuilder.Configurations.Add(new DeviceSensorViewMap());
            modelBuilder.Configurations.Add(new FloorViewMap());
            modelBuilder.Configurations.Add(new ModeInfoViewMap());
            modelBuilder.Configurations.Add(new RoomDeviceViewMap());
            modelBuilder.Configurations.Add(new RoomViewMap());
        }
    }
}
