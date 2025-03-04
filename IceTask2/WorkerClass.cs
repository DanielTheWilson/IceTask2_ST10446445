using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace IceTask2
{
    internal class WorkerClass
    {
       public WorkerClass() { }

        public void Sound1()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/lab_services_student/Music/WAV sounds/aykroyd_coneheads_unacceptable.wav";
            player.Play();
        }

        public void Sound2()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/lab_services_student/Music/WAV sounds/coburn_payback_who_gives.wav";
            player.Play();
        }

        public void Sound3()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/lab_services_student/Music/WAV sounds/collateral_damage_no.wav";
            player.Play();
        }

    }
}

