
        //Prendo il numero lunghezza 17 cifre da calcolare il check digit 
        string numero = "12320444901678404";
        //Lo trasformo in un array
        int[] cifre = numero.ToCharArray().Select(c => c - '0').ToArray();
        //Variabile per la somma dei numeri moltiplicati
        int risultato = 0;
        //Contatore di interazione
        int i = 0;

        //Ciclo while per estrarre la somma moltiplicando i numeri x3 e x1
        while (i < cifre.Length)
        {
            if (i % 2 == 0)
            {
                risultato += cifre[i] * 3;
            }
            else
            {
                risultato += cifre[i];
            }
            i++;
        }

        //Creo variabile che associo alla somma dei numeri del SSCC per determinare il successivo numero divisibile per 10 che torni resto 0
        int nextDec = risultato;

        //Ciclo per determinare il numero divisibile per 10
        while (nextDec % 10 != 0)
        {
            nextDec++;
        }

        //Check Digit
        int checkDigit = nextDec - risultato;

        //Stampo Check Digit
        Console.WriteLine("Check Digit:"+checkDigit);

        //Stampo SSCC
        Console.WriteLine("SSCC: 00"+numero+checkDigit);
