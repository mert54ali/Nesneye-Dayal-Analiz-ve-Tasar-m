<<<<<<< HEAD
﻿using tasarimproje.Interfaces;
using tasarimproje.Patterns.Behavioral;

namespace tasarimproje.Models
{
    public class Siparis
    {
        public int OrderId { get; set; }
        public ISiparisDurumu State { get; set; }

        public Siparis()
        {
            OrderId = new System.Random().Next(1000, 9999);
            State = new PendingState(); 
        }

        public void Next() => State.Next(this);
        public void Cancel() => State.Cancel(this);
        public string GetStatus() => State.GetStatus();

        public void SetState(ISiparisDurumu newState) => this.State = newState;
    }
=======
﻿using tasarimproje.Interfaces;
using tasarimproje.Patterns.Behavioral;

namespace tasarimproje.Models
{
    public class Siparis
    {
        public int OrderId { get; set; }
        public ISiparisDurumu State { get; set; }

        public Siparis()
        {
            OrderId = new System.Random().Next(1000, 9999);
            State = new PendingState(); 
        }

        public void Next() => State.Next(this);
        public void Cancel() => State.Cancel(this);
        public string GetStatus() => State.GetStatus();

        public void SetState(ISiparisDurumu newState) => this.State = newState;
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}