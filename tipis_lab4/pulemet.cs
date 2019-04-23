using System;

namespace lab_3 {
  public class pulemet {
    public int V = 1, maxTst = 90, nag1st = 2, Vosts = 1;
    const int Tokrsr = 23;
    public int Stoptime;
    public int tekTst = Tokrsr;
    public int Shot {
      get {
        return tekTst;
      } set {
        tekTst = nag1st * value;
      }
    }
    public void CheckTemp() => Console.WriteLine("Текущая температура ствола {0}C", tekTst);
    public void ChangeSt() {
      tekTst = Tokrsr;
      Console.WriteLine("Ствол сменён. Текущая температура ствола {0}C", tekTst);
    }
    public int Pause {
      get {
        return Stoptime;
      } set {
        Stoptime = DateTime.Now.Second + (V * value);
      }
    }
  }
}