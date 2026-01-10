using System;
class Program {
    static void Main() {
        tabelaHiragana();
    }

    public void tabelaHiragana(){
        Console.WriteLine(@"
▀█▀ ▄▀█ █▄▄ █▀▀ █░░ ▄▀█   █░█ █ █▀█ ▄▀█ █▀▀ ▄▀█ █▄░█ ▄▀█
░█░ █▀█ █▄█ ██▄ █▄▄ █▀█   █▀█ █ █▀▄ █▀█ █▄█ █▀█ █░▀█ █▀█");
        Console.WriteLine("[ん] = N, [わ] = WA, [ら] = RA, [や] = YA, [ま] = MA, [は] = HA, [な = NA], [た] = TA, [さ] = SA, [か] = KA, [あ] = A\n\t\t   [り] = RI,\t       [み] = MI, [ひ] = HI, [に] = NI, [ち] = CHI, [し] = SHI, [き] = KI, [い] = I\n\t\t   [る] = RU, [ゆ] = YU, [む] = MU, [ふ] = FU, [ぬ] = NU, [つ] = TSU, [す] = SU, [く] = KU, [う] = U\n\t\t   [れ] = RE, \t       [め] = ME, [へ] = HE, [ね] = NE, [て] = TE, [せ] = SE, [け] = KE, [え] = E\n\t [を] = O, [ろ] = RO, [よ] = YO, [も] = MO, [ほ] = HO, [の] = NO, [と] = TO, [そ] = SO, [こ] = KO, [お] = O");
    }
}