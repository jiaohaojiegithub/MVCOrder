namespace MVCOrder.Models.YKT
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class yikatong : DbContext
    {
        public yikatong()
            : base("name=yikatong")
        {
        }

        public virtual DbSet<car_no> car_no { get; set; }
        public virtual DbSet<car_type> car_type { get; set; }
        public virtual DbSet<card_init_record> card_init_record { get; set; }
        public virtual DbSet<card_make> card_make { get; set; }
        public virtual DbSet<card_type> card_type { get; set; }
        public virtual DbSet<color_type> color_type { get; set; }
        public virtual DbSet<customer> customer { get; set; }
        public virtual DbSet<device> device { get; set; }
        public virtual DbSet<devtype> devtype { get; set; }
        public virtual DbSet<door_card_make> door_card_make { get; set; }
        public virtual DbSet<door_dev_parm> door_dev_parm { get; set; }
        public virtual DbSet<EateryCardPay> EateryCardPay { get; set; }
        public virtual DbSet<EateryComputer> EateryComputer { get; set; }
        public virtual DbSet<EateryCstDinRec> EateryCstDinRec { get; set; }
        public virtual DbSet<EateryCustLevel> EateryCustLevel { get; set; }
        public virtual DbSet<EateryDevice> EateryDevice { get; set; }
        public virtual DbSet<EateryDevicePrice> EateryDevicePrice { get; set; }
        public virtual DbSet<EateryDeviceSet> EateryDeviceSet { get; set; }
        public virtual DbSet<EateryDeviceTime> EateryDeviceTime { get; set; }
        public virtual DbSet<EateryDinner> EateryDinner { get; set; }
        public virtual DbSet<EateryDinnerAdd> EateryDinnerAdd { get; set; }
        public virtual DbSet<EateryLevelSet> EateryLevelSet { get; set; }
        public virtual DbSet<handoperator> handoperator { get; set; }
        public virtual DbSet<hmd> hmd { get; set; }
        public virtual DbSet<in_park> in_park { get; set; }
        public virtual DbSet<in_park_history> in_park_history { get; set; }
        public virtual DbSet<InvalidOpenGate> InvalidOpenGate { get; set; }
        public virtual DbSet<kq_chuCai> kq_chuCai { get; set; }
        public virtual DbSet<kq_daKa> kq_daKa { get; set; }
        public virtual DbSet<kq_daKaH> kq_daKaH { get; set; }
        public virtual DbSet<kq_dept> kq_dept { get; set; }
        public virtual DbSet<kq_deptWork> kq_deptWork { get; set; }
        public virtual DbSet<kq_history> kq_history { get; set; }
        public virtual DbSet<kq_holiday> kq_holiday { get; set; }
        public virtual DbSet<kq_huiZongH> kq_huiZongH { get; set; }
        public virtual DbSet<kq_jiaBan> kq_jiaBan { get; set; }
        public virtual DbSet<kq_mingXiH> kq_mingXiH { get; set; }
        public virtual DbSet<kq_qianKa> kq_qianKa { get; set; }
        public virtual DbSet<kq_qingJia> kq_qingJia { get; set; }
        public virtual DbSet<kq_rule> kq_rule { get; set; }
        public virtual DbSet<kq_work> kq_work { get; set; }
        public virtual DbSet<kq_workQueueH> kq_workQueueH { get; set; }
        public virtual DbSet<kq_wrkHoliday> kq_wrkHoliday { get; set; }
        public virtual DbSet<lift_price> lift_price { get; set; }
        public virtual DbSet<M_ContrlNo> M_ContrlNo { get; set; }
        public virtual DbSet<M_ControlDefine> M_ControlDefine { get; set; }
        public virtual DbSet<M_controlStall> M_controlStall { get; set; }
        public virtual DbSet<M_Record> M_Record { get; set; }
        public virtual DbSet<M_Record_history> M_Record_history { get; set; }
        public virtual DbSet<M_Time> M_Time { get; set; }
        public virtual DbSet<M_TimeTask> M_TimeTask { get; set; }
        public virtual DbSet<_operator> _operator { get; set; }
        public virtual DbSet<out_park> out_park { get; set; }
        public virtual DbSet<out_park_history> out_park_history { get; set; }
        public virtual DbSet<PA_tboLocal> PA_tboLocal { get; set; }
        public virtual DbSet<PA_tboScheme> PA_tboScheme { get; set; }
        public virtual DbSet<park> park { get; set; }
        public virtual DbSet<park_card_make> park_card_make { get; set; }
        public virtual DbSet<park_dev_parm> park_dev_parm { get; set; }
        public virtual DbSet<park_stall> park_stall { get; set; }
        public virtual DbSet<park_timesec> park_timesec { get; set; }
        public virtual DbSet<parking> parking { get; set; }
        public virtual DbSet<parkingInside> parkingInside { get; set; }
        public virtual DbSet<subsystem> subsystem { get; set; }
        public virtual DbSet<sysindex> sysindex { get; set; }
        public virtual DbSet<Table_MoneyDiscount> Table_MoneyDiscount { get; set; }
        public virtual DbSet<Table_PointDiscount> Table_PointDiscount { get; set; }
        public virtual DbSet<Table_Visitor> Table_Visitor { get; set; }
        public virtual DbSet<white_list> white_list { get; set; }
        public virtual DbSet<white_list2> white_list2 { get; set; }
        public virtual DbSet<xg_line> xg_line { get; set; }
        public virtual DbSet<xg_node> xg_node { get; set; }
        public virtual DbSet<xg_plan> xg_plan { get; set; }
        public virtual DbSet<card_charge> card_charge { get; set; }
        public virtual DbSet<card_delay> card_delay { get; set; }
        public virtual DbSet<card_lost> card_lost { get; set; }
        public virtual DbSet<card_quit> card_quit { get; set; }
        public virtual DbSet<Card_quit_Pay> Card_quit_Pay { get; set; }
        public virtual DbSet<card_status> card_status { get; set; }
        public virtual DbSet<CardRecharge> CardRecharge { get; set; }
        public virtual DbSet<DeviceRecognise> DeviceRecognise { get; set; }
        public virtual DbSet<EateryWhitelist> EateryWhitelist { get; set; }
        public virtual DbSet<fee_std> fee_std { get; set; }
        public virtual DbSet<hmd_list> hmd_list { get; set; }
        public virtual DbSet<lift_card_make> lift_card_make { get; set; }
        public virtual DbSet<lift_info> lift_info { get; set; }
        public virtual DbSet<lift_record> lift_record { get; set; }
        public virtual DbSet<log> log { get; set; }
        public virtual DbSet<M_log> M_log { get; set; }
        public virtual DbSet<operator_right> operator_right { get; set; }
        public virtual DbSet<PA_tboDevice> PA_tboDevice { get; set; }
        public virtual DbSet<Park_Auto_Pay_Record> Park_Auto_Pay_Record { get; set; }
        public virtual DbSet<park_central_pay> park_central_pay { get; set; }
        public virtual DbSet<Park_Device_State> Park_Device_State { get; set; }
        public virtual DbSet<park_pay_bill> park_pay_bill { get; set; }
        public virtual DbSet<Park_Pay_Device> Park_Pay_Device { get; set; }
        public virtual DbSet<parkingless520> parkingless520 { get; set; }
        public virtual DbSet<ParkSearch_area_dictionary> ParkSearch_area_dictionary { get; set; }
        public virtual DbSet<Parksearch_Area_line> Parksearch_Area_line { get; set; }
        public virtual DbSet<ParkSearch_car_log> ParkSearch_car_log { get; set; }
        public virtual DbSet<ParkSearch_car_record> ParkSearch_car_record { get; set; }
        public virtual DbSet<ParkSearch_map> ParkSearch_map { get; set; }
        public virtual DbSet<Parksearch_pos> Parksearch_pos { get; set; }
        public virtual DbSet<Parksearch_recognizer> Parksearch_recognizer { get; set; }
        public virtual DbSet<PayMethod> PayMethod { get; set; }
        public virtual DbSet<remote_control> remote_control { get; set; }
        public virtual DbSet<stall_occuppy> stall_occuppy { get; set; }
        public virtual DbSet<SystemSet> SystemSet { get; set; }
        public virtual DbSet<Table_AliasOfPlate> Table_AliasOfPlate { get; set; }
        public virtual DbSet<Table_XML> Table_XML { get; set; }
        public virtual DbSet<Ticket_Info> Ticket_Info { get; set; }
        public virtual DbSet<wkczyq> wkczyq { get; set; }
        public virtual DbSet<xg_plan_detail> xg_plan_detail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<car_no>()
                .Property(e => e.car_no1)
                .IsUnicode(false);

            modelBuilder.Entity<car_no>()
                .Property(e => e.car_name)
                .IsUnicode(false);

            modelBuilder.Entity<car_type>()
                .Property(e => e.car_tname)
                .IsUnicode(false);

            modelBuilder.Entity<card_init_record>()
                .Property(e => e.op_name)
                .IsUnicode(false);

            modelBuilder.Entity<card_make>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<card_type>()
                .Property(e => e.card_tname)
                .IsUnicode(false);

            modelBuilder.Entity<card_type>()
                .Property(e => e.card_showname)
                .IsUnicode(false);

            modelBuilder.Entity<color_type>()
                .Property(e => e.color_tname)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.cust_name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.cust_password)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.cust_nick)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.phone_no)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.idcard)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.photo)
                .IsUnicode(false);

            modelBuilder.Entity<device>()
                .Property(e => e.dev_name)
                .IsUnicode(false);

            modelBuilder.Entity<device>()
                .Property(e => e.computer)
                .IsUnicode(false);

            modelBuilder.Entity<device>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<devtype>()
                .Property(e => e.dev_tname)
                .IsUnicode(false);

            modelBuilder.Entity<door_card_make>()
                .Property(e => e.TimeNo)
                .IsUnicode(false);

            modelBuilder.Entity<door_card_make>()
                .Property(e => e.MachNo)
                .IsUnicode(false);

            modelBuilder.Entity<door_card_make>()
                .Property(e => e.DownMachNo)
                .IsUnicode(false);

            modelBuilder.Entity<EateryCardPay>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<EateryCardPay>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<EateryComputer>()
                .Property(e => e.CmpName)
                .IsUnicode(false);

            modelBuilder.Entity<EateryComputer>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<EateryComputer>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<EateryCstDinRec>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<EateryCstDinRec>()
                .Property(e => e.amt)
                .HasPrecision(9, 1);

            modelBuilder.Entity<EateryCstDinRec>()
                .Property(e => e.addAmt)
                .HasPrecision(9, 1);

            modelBuilder.Entity<EateryCstDinRec>()
                .Property(e => e.realAmt)
                .HasPrecision(9, 1);

            modelBuilder.Entity<EateryCstDinRec>()
                .Property(e => e.leftAmt)
                .HasPrecision(9, 1);

            modelBuilder.Entity<EateryCustLevel>()
                .Property(e => e.dinner)
                .IsUnicode(false);

            modelBuilder.Entity<EateryCustLevel>()
                .Property(e => e.MatchDevStr)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDevice>()
                .Property(e => e.DevName)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDevice>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDevice>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDevice>()
                .Property(e => e.devIP)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDevicePrice>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDevicePrice>()
                .Property(e => e.MenuPrice)
                .HasPrecision(9, 1);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.DayName)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.Start1)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.End1)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.Start2)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.End2)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.Start3)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.End3)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.Start4)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.End4)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.Start5)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.End5)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.Start6)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.End6)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.Start7)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDeviceTime>()
                .Property(e => e.End7)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDinner>()
                .Property(e => e.DinName)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDinner>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDinner>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDinnerAdd>()
                .Property(e => e.DayName)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDinnerAdd>()
                .Property(e => e.Start1)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDinnerAdd>()
                .Property(e => e.End1)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDinnerAdd>()
                .Property(e => e.Start2)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDinnerAdd>()
                .Property(e => e.End2)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDinnerAdd>()
                .Property(e => e.Start3)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDinnerAdd>()
                .Property(e => e.End3)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDinnerAdd>()
                .Property(e => e.BreakfastAmt)
                .HasPrecision(9, 1);

            modelBuilder.Entity<EateryDinnerAdd>()
                .Property(e => e.LunchAmt)
                .HasPrecision(9, 1);

            modelBuilder.Entity<EateryDinnerAdd>()
                .Property(e => e.SupperAmt)
                .HasPrecision(9, 1);

            modelBuilder.Entity<EateryDinnerAdd>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDinnerAdd>()
                .Property(e => e.Start4)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDinnerAdd>()
                .Property(e => e.End4)
                .IsUnicode(false);

            modelBuilder.Entity<EateryDinnerAdd>()
                .Property(e => e.NightAmt)
                .HasPrecision(9, 1);

            modelBuilder.Entity<EateryLevelSet>()
                .Property(e => e.LevelName)
                .IsUnicode(false);

            modelBuilder.Entity<EateryLevelSet>()
                .Property(e => e.amt1)
                .HasPrecision(9, 1);

            modelBuilder.Entity<EateryLevelSet>()
                .Property(e => e.amt2)
                .HasPrecision(9, 1);

            modelBuilder.Entity<EateryLevelSet>()
                .Property(e => e.amt3)
                .HasPrecision(9, 1);

            modelBuilder.Entity<EateryLevelSet>()
                .Property(e => e.amt4)
                .HasPrecision(9, 1);

            modelBuilder.Entity<EateryLevelSet>()
                .Property(e => e.fee1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EateryLevelSet>()
                .Property(e => e.fee2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EateryLevelSet>()
                .Property(e => e.fee3)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EateryLevelSet>()
                .Property(e => e.fee4)
                .HasPrecision(18, 0);

            modelBuilder.Entity<handoperator>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<handoperator>()
                .Property(e => e.computer)
                .IsUnicode(false);

            modelBuilder.Entity<in_park>()
                .Property(e => e.carno)
                .IsUnicode(false);

            modelBuilder.Entity<in_park>()
                .Property(e => e.in_pic)
                .IsUnicode(false);

            modelBuilder.Entity<in_park>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<in_park>()
                .Property(e => e.CapturePlate)
                .IsUnicode(false);

            modelBuilder.Entity<in_park_history>()
                .Property(e => e.carno)
                .IsUnicode(false);

            modelBuilder.Entity<in_park_history>()
                .Property(e => e.in_pic)
                .IsUnicode(false);

            modelBuilder.Entity<in_park_history>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<InvalidOpenGate>()
                .Property(e => e.gateopen_pic)
                .IsUnicode(false);

            modelBuilder.Entity<InvalidOpenGate>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<kq_chuCai>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<kq_chuCai>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<kq_daKa>()
                .Property(e => e.doorName)
                .IsUnicode(false);

            modelBuilder.Entity<kq_daKaH>()
                .Property(e => e.doorName)
                .IsUnicode(false);

            modelBuilder.Entity<kq_dept>()
                .Property(e => e.deptName)
                .IsUnicode(false);

            modelBuilder.Entity<kq_holiday>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<kq_holiday>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<kq_jiaBan>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<kq_jiaBan>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<kq_qianKa>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<kq_qianKa>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<kq_qingJia>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<kq_qingJia>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<kq_rule>()
                .Property(e => e.JB_startTime)
                .IsUnicode(false);

            modelBuilder.Entity<kq_rule>()
                .Property(e => e.JB_endTime)
                .IsUnicode(false);

            modelBuilder.Entity<kq_work>()
                .Property(e => e.wrkName)
                .IsUnicode(false);

            modelBuilder.Entity<kq_work>()
                .Property(e => e.wrkStart1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kq_work>()
                .Property(e => e.wrkEnd1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kq_work>()
                .Property(e => e.wrkStart2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kq_work>()
                .Property(e => e.wrkEnd2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kq_work>()
                .Property(e => e.wrkStart3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kq_work>()
                .Property(e => e.wrkEnd3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kq_wrkHoliday>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<kq_wrkHoliday>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<M_ControlDefine>()
                .Property(e => e.ReadNo)
                .IsUnicode(false);

            modelBuilder.Entity<M_ControlDefine>()
                .Property(e => e.DoorName)
                .IsUnicode(false);

            modelBuilder.Entity<M_ControlDefine>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<M_ControlDefine>()
                .Property(e => e.Port)
                .IsUnicode(false);

            modelBuilder.Entity<M_ControlDefine>()
                .Property(e => e.Watch)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<M_ControlDefine>()
                .Property(e => e.op_name)
                .IsUnicode(false);

            modelBuilder.Entity<M_controlStall>()
                .Property(e => e.sName)
                .IsUnicode(false);

            modelBuilder.Entity<M_controlStall>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record>()
                .Property(e => e.CardNo)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record>()
                .Property(e => e.Cust_nick)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record>()
                .Property(e => e.Cust_name)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record>()
                .Property(e => e.ControlNo)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record>()
                .Property(e => e.ReadNo)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record>()
                .Property(e => e.DoorName)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record_history>()
                .Property(e => e.CardNo)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record_history>()
                .Property(e => e.Cust_nick)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record_history>()
                .Property(e => e.Cust_name)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record_history>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record_history>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record_history>()
                .Property(e => e.ControlNo)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record_history>()
                .Property(e => e.ReadNo)
                .IsUnicode(false);

            modelBuilder.Entity<M_Record_history>()
                .Property(e => e.DoorName)
                .IsUnicode(false);

            modelBuilder.Entity<M_Time>()
                .Property(e => e.TimeName)
                .IsUnicode(false);

            modelBuilder.Entity<M_Time>()
                .Property(e => e.bDate)
                .IsUnicode(false);

            modelBuilder.Entity<M_Time>()
                .Property(e => e.eDate)
                .IsUnicode(false);

            modelBuilder.Entity<M_Time>()
                .Property(e => e.Week)
                .IsUnicode(false);

            modelBuilder.Entity<M_Time>()
                .Property(e => e.Time11)
                .IsUnicode(false);

            modelBuilder.Entity<M_Time>()
                .Property(e => e.Time12)
                .IsUnicode(false);

            modelBuilder.Entity<M_Time>()
                .Property(e => e.Time21)
                .IsUnicode(false);

            modelBuilder.Entity<M_Time>()
                .Property(e => e.Time22)
                .IsUnicode(false);

            modelBuilder.Entity<M_Time>()
                .Property(e => e.Time31)
                .IsUnicode(false);

            modelBuilder.Entity<M_Time>()
                .Property(e => e.Time32)
                .IsUnicode(false);

            modelBuilder.Entity<M_TimeTask>()
                .Property(e => e.devID)
                .IsUnicode(false);

            modelBuilder.Entity<M_TimeTask>()
                .Property(e => e.taskDT)
                .IsUnicode(false);

            modelBuilder.Entity<M_TimeTask>()
                .Property(e => e.taskTime)
                .IsUnicode(false);

            modelBuilder.Entity<_operator>()
                .Property(e => e.op_name)
                .IsUnicode(false);

            modelBuilder.Entity<_operator>()
                .Property(e => e.op_pass)
                .IsUnicode(false);

            modelBuilder.Entity<_operator>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<_operator>()
                .Property(e => e.creator)
                .IsUnicode(false);

            modelBuilder.Entity<out_park>()
                .Property(e => e.carno)
                .IsUnicode(false);

            modelBuilder.Entity<out_park>()
                .Property(e => e.out_pic)
                .IsUnicode(false);

            modelBuilder.Entity<out_park>()
                .Property(e => e.ident_pic)
                .IsUnicode(false);

            modelBuilder.Entity<out_park>()
                .Property(e => e.money1)
                .HasPrecision(10, 2);

            modelBuilder.Entity<out_park>()
                .Property(e => e.money2)
                .HasPrecision(10, 2);

            modelBuilder.Entity<out_park>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<out_park>()
                .Property(e => e.invoice)
                .IsUnicode(false);

            modelBuilder.Entity<out_park>()
                .Property(e => e.out_pic2)
                .IsUnicode(false);

            modelBuilder.Entity<out_park>()
                .Property(e => e.ReasonAllowFree)
                .IsUnicode(false);

            modelBuilder.Entity<out_park>()
                .Property(e => e.CapturePlate)
                .IsUnicode(false);

            modelBuilder.Entity<out_park>()
                .Property(e => e.payType)
                .IsUnicode(false);

            modelBuilder.Entity<out_park_history>()
                .Property(e => e.carno)
                .IsUnicode(false);

            modelBuilder.Entity<out_park_history>()
                .Property(e => e.out_pic)
                .IsUnicode(false);

            modelBuilder.Entity<out_park_history>()
                .Property(e => e.ident_pic)
                .IsUnicode(false);

            modelBuilder.Entity<out_park_history>()
                .Property(e => e.money1)
                .HasPrecision(10, 2);

            modelBuilder.Entity<out_park_history>()
                .Property(e => e.money2)
                .HasPrecision(10, 2);

            modelBuilder.Entity<out_park_history>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<out_park_history>()
                .Property(e => e.invoice)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboLocal>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboLocal>()
                .Property(e => e.RecogniseIP)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboLocal>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboLocal>()
                .Property(e => e.ScreenCOM)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboLocal>()
                .Property(e => e.ScreenIP)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboLocal>()
                .Property(e => e.OpenGateCOM)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboLocal>()
                .Property(e => e.VideoSource)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboLocal>()
                .Property(e => e.CameraIP)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboLocal>()
                .Property(e => e.CameraUsername)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboLocal>()
                .Property(e => e.CameraPassword)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboLocal>()
                .Property(e => e.VoiceModuleCom)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboLocal>()
                .Property(e => e.ControlPanelIP)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboScheme>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboScheme>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboScheme>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboScheme>()
                .Property(e => e.Led)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboScheme>()
                .Property(e => e.CaptureLayout)
                .IsUnicode(false);

            modelBuilder.Entity<park>()
                .Property(e => e.park_name)
                .IsUnicode(false);

            modelBuilder.Entity<park>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<park_card_make>()
                .Property(e => e.carno)
                .IsUnicode(false);

            modelBuilder.Entity<park_card_make>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<park_card_make>()
                .Property(e => e.matchDevStr)
                .IsUnicode(false);

            modelBuilder.Entity<park_dev_parm>()
                .Property(e => e.sysflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<park_dev_parm>()
                .Property(e => e.commpass)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<park_dev_parm>()
                .Property(e => e.syspass)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<park_dev_parm>()
                .Property(e => e.userpass)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<park_dev_parm>()
                .Property(e => e.light)
                .IsUnicode(false);

            modelBuilder.Entity<park_stall>()
                .Property(e => e.stall_name)
                .IsUnicode(false);

            modelBuilder.Entity<park_stall>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<park_timesec>()
                .Property(e => e.timename)
                .IsUnicode(false);

            modelBuilder.Entity<park_timesec>()
                .Property(e => e.timesec1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<park_timesec>()
                .Property(e => e.timesec2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<park_timesec>()
                .Property(e => e.timedate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<parking>()
                .Property(e => e.carno)
                .IsUnicode(false);

            modelBuilder.Entity<parking>()
                .Property(e => e.in_pic)
                .IsUnicode(false);

            modelBuilder.Entity<parking>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<parking>()
                .Property(e => e.small_pic)
                .IsUnicode(false);

            modelBuilder.Entity<parking>()
                .Property(e => e.central_pay_money)
                .HasPrecision(18, 0);

            modelBuilder.Entity<parking>()
                .Property(e => e.CapturePlate)
                .IsUnicode(false);

            modelBuilder.Entity<parkingInside>()
                .Property(e => e.carno)
                .IsUnicode(false);

            modelBuilder.Entity<parkingInside>()
                .Property(e => e.in_pic)
                .IsUnicode(false);

            modelBuilder.Entity<parkingInside>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<parkingInside>()
                .Property(e => e.small_pic)
                .IsUnicode(false);

            modelBuilder.Entity<subsystem>()
                .Property(e => e.sysflag)
                .IsUnicode(false);

            modelBuilder.Entity<subsystem>()
                .Property(e => e.commpass)
                .IsUnicode(false);

            modelBuilder.Entity<subsystem>()
                .Property(e => e.syspass)
                .IsUnicode(false);

            modelBuilder.Entity<subsystem>()
                .Property(e => e.userpass)
                .IsUnicode(false);

            modelBuilder.Entity<sysindex>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<Table_MoneyDiscount>()
                .Property(e => e.Discount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Table_PointDiscount>()
                .Property(e => e.Discount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Table_Visitor>()
                .Property(e => e.carno)
                .IsUnicode(false);

            modelBuilder.Entity<Table_Visitor>()
                .Property(e => e.cust_name)
                .IsUnicode(false);

            modelBuilder.Entity<Table_Visitor>()
                .Property(e => e.matchDevStr)
                .IsUnicode(false);

            modelBuilder.Entity<Table_Visitor>()
                .Property(e => e.passcode)
                .IsUnicode(false);

            modelBuilder.Entity<Table_Visitor>()
                .Property(e => e.visitor_desc)
                .IsUnicode(false);

            modelBuilder.Entity<Table_Visitor>()
                .Property(e => e.cid)
                .IsUnicode(false);

            modelBuilder.Entity<Table_Visitor>()
                .Property(e => e.block_name)
                .IsUnicode(false);

            modelBuilder.Entity<Table_Visitor>()
                .Property(e => e.plate_number)
                .IsUnicode(false);

            modelBuilder.Entity<Table_Visitor>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Table_Visitor>()
                .Property(e => e.arrive_at)
                .IsUnicode(false);

            modelBuilder.Entity<Table_Visitor>()
                .Property(e => e.leave_at)
                .IsUnicode(false);

            modelBuilder.Entity<white_list>()
                .Property(e => e.carno)
                .IsUnicode(false);

            modelBuilder.Entity<white_list2>()
                .Property(e => e.Pwd)
                .IsUnicode(false);

            modelBuilder.Entity<xg_line>()
                .Property(e => e.line_name)
                .IsUnicode(false);

            modelBuilder.Entity<xg_node>()
                .Property(e => e.node_name)
                .IsUnicode(false);

            modelBuilder.Entity<xg_node>()
                .Property(e => e.door_sn)
                .IsUnicode(false);

            modelBuilder.Entity<xg_node>()
                .Property(e => e.door_readno)
                .IsUnicode(false);

            modelBuilder.Entity<card_charge>()
                .Property(e => e.CustName)
                .IsUnicode(false);

            modelBuilder.Entity<card_charge>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<card_charge>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<card_delay>()
                .Property(e => e.money)
                .HasPrecision(10, 2);

            modelBuilder.Entity<card_delay>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<card_delay>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<card_lost>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<card_lost>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<card_quit>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<card_quit>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<Card_quit_Pay>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<Card_quit_Pay>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<card_status>()
                .Property(e => e.card_statusname)
                .IsUnicode(false);

            modelBuilder.Entity<CardRecharge>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<CardRecharge>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<DeviceRecognise>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EateryWhitelist>()
                .Property(e => e.cust_name)
                .IsUnicode(false);

            modelBuilder.Entity<EateryWhitelist>()
                .Property(e => e.balance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<fee_std>()
                .Property(e => e.lx)
                .IsUnicode(false);

            modelBuilder.Entity<fee_std>()
                .Property(e => e.csz)
                .IsUnicode(false);

            modelBuilder.Entity<hmd_list>()
                .Property(e => e.carno)
                .IsUnicode(false);

            modelBuilder.Entity<lift_card_make>()
                .Property(e => e.door_no)
                .IsUnicode(false);

            modelBuilder.Entity<lift_card_make>()
                .Property(e => e.room_no)
                .IsUnicode(false);

            modelBuilder.Entity<lift_card_make>()
                .Property(e => e.allowlift)
                .IsUnicode(false);

            modelBuilder.Entity<lift_card_make>()
                .Property(e => e.allowfloor)
                .IsUnicode(false);

            modelBuilder.Entity<lift_card_make>()
                .Property(e => e.allowlift2)
                .IsUnicode(false);

            modelBuilder.Entity<lift_card_make>()
                .Property(e => e.allowfloor2)
                .IsUnicode(false);

            modelBuilder.Entity<lift_card_make>()
                .Property(e => e.allowlift3)
                .IsUnicode(false);

            modelBuilder.Entity<lift_card_make>()
                .Property(e => e.allowfloor3)
                .IsFixedLength();

            modelBuilder.Entity<lift_card_make>()
                .Property(e => e.weekStr)
                .IsUnicode(false);

            modelBuilder.Entity<lift_info>()
                .Property(e => e.lift_name)
                .IsUnicode(false);

            modelBuilder.Entity<lift_info>()
                .Property(e => e.lift_type)
                .IsUnicode(false);

            modelBuilder.Entity<lift_info>()
                .Property(e => e.bureau_no)
                .IsUnicode(false);

            modelBuilder.Entity<lift_info>()
                .Property(e => e.controlfloor)
                .IsUnicode(false);

            modelBuilder.Entity<M_log>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboDevice>()
                .Property(e => e.Display)
                .IsUnicode(false);

            modelBuilder.Entity<PA_tboDevice>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Park_Auto_Pay_Record>()
                .Property(e => e.serial_number)
                .IsUnicode(false);

            modelBuilder.Entity<Park_Auto_Pay_Record>()
                .Property(e => e.pay_type)
                .IsUnicode(false);

            modelBuilder.Entity<Park_Auto_Pay_Record>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<park_central_pay>()
                .Property(e => e.carNo)
                .IsUnicode(false);

            modelBuilder.Entity<park_central_pay>()
                .Property(e => e.in_pic)
                .IsUnicode(false);

            modelBuilder.Entity<park_central_pay>()
                .Property(e => e.money)
                .HasPrecision(10, 2);

            modelBuilder.Entity<park_central_pay>()
                .Property(e => e.discountM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<park_central_pay>()
                .Property(e => e.paidM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<park_central_pay>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<park_central_pay>()
                .Property(e => e.PayMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Park_Device_State>()
                .Property(e => e.Printer)
                .IsUnicode(false);

            modelBuilder.Entity<Park_Device_State>()
                .Property(e => e.scanner)
                .IsUnicode(false);

            modelBuilder.Entity<Park_Device_State>()
                .Property(e => e.cashIn)
                .IsUnicode(false);

            modelBuilder.Entity<Park_Device_State>()
                .Property(e => e.cashOut)
                .IsUnicode(false);

            modelBuilder.Entity<Park_Device_State>()
                .Property(e => e.coinIn)
                .IsUnicode(false);

            modelBuilder.Entity<Park_Device_State>()
                .Property(e => e.coinOut)
                .IsUnicode(false);

            modelBuilder.Entity<Park_Device_State>()
                .Property(e => e.cardRead)
                .IsUnicode(false);

            modelBuilder.Entity<park_pay_bill>()
                .Property(e => e.carNo)
                .IsUnicode(false);

            modelBuilder.Entity<park_pay_bill>()
                .Property(e => e.money)
                .HasPrecision(10, 2);

            modelBuilder.Entity<park_pay_bill>()
                .Property(e => e.discountM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<park_pay_bill>()
                .Property(e => e.paidM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<park_pay_bill>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<Park_Pay_Device>()
                .Property(e => e.device_type)
                .IsUnicode(false);

            modelBuilder.Entity<Park_Pay_Device>()
                .Property(e => e.device_IP)
                .IsUnicode(false);

            modelBuilder.Entity<Park_Pay_Device>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<parkingless520>()
                .Property(e => e.carno)
                .IsUnicode(false);

            modelBuilder.Entity<parkingless520>()
                .Property(e => e.in_pic)
                .IsUnicode(false);

            modelBuilder.Entity<parkingless520>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<parkingless520>()
                .Property(e => e.small_pic)
                .IsUnicode(false);

            modelBuilder.Entity<parkingless520>()
                .Property(e => e.central_pay_money)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ParkSearch_area_dictionary>()
                .Property(e => e.areaName)
                .IsUnicode(false);

            modelBuilder.Entity<Parksearch_Area_line>()
                .Property(e => e.Rermark)
                .IsUnicode(false);

            modelBuilder.Entity<ParkSearch_car_log>()
                .Property(e => e.devName)
                .IsUnicode(false);

            modelBuilder.Entity<ParkSearch_car_record>()
                .Property(e => e.devName)
                .IsUnicode(false);

            modelBuilder.Entity<ParkSearch_car_record>()
                .Property(e => e.plateName)
                .IsUnicode(false);

            modelBuilder.Entity<ParkSearch_car_record>()
                .Property(e => e.devIP)
                .IsUnicode(false);

            modelBuilder.Entity<ParkSearch_car_record>()
                .Property(e => e.smallPicPath)
                .IsFixedLength();

            modelBuilder.Entity<ParkSearch_car_record>()
                .Property(e => e.picPath)
                .IsUnicode(false);

            modelBuilder.Entity<ParkSearch_car_record>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<ParkSearch_map>()
                .Property(e => e.mapName)
                .IsUnicode(false);

            modelBuilder.Entity<ParkSearch_map>()
                .Property(e => e.mapPath)
                .IsUnicode(false);

            modelBuilder.Entity<Parksearch_pos>()
                .Property(e => e.posName)
                .IsUnicode(false);

            modelBuilder.Entity<Parksearch_pos>()
                .Property(e => e.posIP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Parksearch_pos>()
                .Property(e => e.areaMapPath)
                .IsUnicode(false);

            modelBuilder.Entity<Parksearch_pos>()
                .Property(e => e.Rermark)
                .IsUnicode(false);

            modelBuilder.Entity<Parksearch_recognizer>()
                .Property(e => e.devName)
                .IsUnicode(false);

            modelBuilder.Entity<Parksearch_recognizer>()
                .Property(e => e.devIP)
                .IsUnicode(false);

            modelBuilder.Entity<Parksearch_recognizer>()
                .Property(e => e.fixLocation)
                .IsUnicode(false);

            modelBuilder.Entity<Parksearch_recognizer>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<PayMethod>()
                .Property(e => e.CloudRootAddress)
                .IsUnicode(false);

            modelBuilder.Entity<PayMethod>()
                .Property(e => e.CloudInOperate)
                .IsUnicode(false);

            modelBuilder.Entity<PayMethod>()
                .Property(e => e.CloudOutOperate)
                .IsUnicode(false);

            modelBuilder.Entity<PayMethod>()
                .Property(e => e.CloudQueryPay)
                .IsUnicode(false);

            modelBuilder.Entity<PayMethod>()
                .Property(e => e.CloudSyncData)
                .IsUnicode(false);

            modelBuilder.Entity<remote_control>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<remote_control>()
                .Property(e => e.picture)
                .IsUnicode(false);

            modelBuilder.Entity<SystemSet>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<SystemSet>()
                .Property(e => e.Mode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ticket_Info>()
                .Property(e => e.qp_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket_Info>()
                .Property(e => e.vip_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket_Info>()
                .Property(e => e.merchant)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket_Info>()
                .Property(e => e.ticket_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket_Info>()
                .Property(e => e.money)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Ticket_Info>()
                .Property(e => e.deductible_money)
                .HasPrecision(18, 0);

            modelBuilder.Entity<wkczyq>()
                .Property(e => e.balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<xg_plan_detail>()
                .Property(e => e.door_sn)
                .IsUnicode(false);

            modelBuilder.Entity<xg_plan_detail>()
                .Property(e => e.node_name)
                .IsUnicode(false);

            modelBuilder.Entity<xg_plan_detail>()
                .Property(e => e.door_readno)
                .IsUnicode(false);
        }
    }
}
