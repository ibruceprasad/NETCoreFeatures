using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NET8_Features.src._3.DesignPattern._3._2_Builder
{ 
    public record ScreeningInterview(int CommunicationSkill, int ConfidentSkill, int PreviousExpSkill, int EducationSkill, int BackgroundSkill, int Reference)
    {
        public int GetBackgroundSkill() => BackgroundSkill;
        public class Builder
        {
            private int _CommunicationSkill { get; set; }
            private int _ConfidenceSkill { get; set; }
            private int _PreviousExpSkill { get; set; }
            private int _EducationSkill { get; set; }
            private int _BackgroundSkill { get; set; }
            private int _Reference { get; set; }
          
            public void SetCommunicationSkills(int value) => _CommunicationSkill = value;
            public void SetConfidenceSkills(int value) => _ConfidenceSkill = value;
            public void SetPreviousExpSkill(int value) => _PreviousExpSkill = value;
            public void SetEducationSkill(int value) => _EducationSkill = value;
            public void SetBackgroundSkill(int value) => _BackgroundSkill = value;
            public void SetReference(int value) => _Reference = value;
            public static Builder Default() => new Builder();
            public ScreeningInterview Build() => new ScreeningInterview(_CommunicationSkill, _ConfidenceSkill, _PreviousExpSkill, _EducationSkill, _BackgroundSkill, _Reference);
        }
    }
}
