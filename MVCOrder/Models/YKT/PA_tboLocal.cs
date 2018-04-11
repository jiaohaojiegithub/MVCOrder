namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PA_tboLocal
    {
        [Key]
        public int SeqNO { get; set; }

        public int? Region { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? SchemeNO { get; set; }

        public int? GateNO { get; set; }

        public int? InOutFlag { get; set; }

        public int? MonthCarOpenType { get; set; }

        public int? FreeCarOpenType { get; set; }

        public int? TempCarOpenType { get; set; }

        public int? MoneyCarOpenType { get; set; }

        public int? VerifyCarNO { get; set; }

        [StringLength(50)]
        public string RecogniseIP { get; set; }

        public int? ExportNO { get; set; }

        public bool? UsedAV { get; set; }

        [StringLength(1000)]
        public string Memo { get; set; }

        public int? ScreenType { get; set; }

        [StringLength(50)]
        public string ScreenCOM { get; set; }

        [StringLength(50)]
        public string ScreenIP { get; set; }

        public int? ScreenID { get; set; }

        public int? Quality { get; set; }

        public int? OpenGateType { get; set; }

        [StringLength(50)]
        public string OpenGateCOM { get; set; }

        public int? OpenGatePort { get; set; }

        public int? ScreenPort { get; set; }

        public int? AVNO { get; set; }

        public int? SpeechType { get; set; }

        [StringLength(50)]
        public string VideoSource { get; set; }

        [StringLength(50)]
        public string CameraIP { get; set; }

        public int? CameraPort { get; set; }

        [StringLength(50)]
        public string CameraUsername { get; set; }

        [StringLength(50)]
        public string CameraPassword { get; set; }

        public DateTime? BeginTime { get; set; }

        public int? CarID { get; set; }

        public DateTime? DownLstTime { get; set; }

        [StringLength(50)]
        public string VoiceModuleCom { get; set; }

        public int? VoiceModuleID { get; set; }

        public int? park_no { get; set; }

        public int? inside_park { get; set; }

        public int? passBH { get; set; }

        public bool? NonBlock { get; set; }

        public int DeviceSupplier { get; set; }

        [Required]
        [StringLength(30)]
        public string ControlPanelIP { get; set; }

        public int ControlPanelPort { get; set; }
    }
}
