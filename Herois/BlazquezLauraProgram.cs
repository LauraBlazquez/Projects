using System;
namespace GameProject
{
    class BlazquezLauraCode
    {
        static void Main()
        {
            //Constantes inicio y menú
            const string Welcome = "\n¡¡Bienvenido a AdventureQuest!!\n";
            const string Menu = "¿Qué desea hacer ahora mi señor?\n 1. Iniciar una nueva aventura\n 0. Salir";
            const string Bye = "\nGracias por jugar, espero pronto su regreso mi señor.";
            const string ChoiceIntro = "\nAntes de iniciar la travesía, mi señor ha de escoger como quiere que sean sus 4 guerreros.\nEmpecemos con la arquera:";
            const string Life = "¿Cuánta vida quiere que tenga?";
            const string Atac = "¿Cuánta fuerza le quiere asignar?";
            const string Shield = "¿Qué porcentaje de reducción de daño le quiere otorgar?";
            const string MsgErrorOption = "\nLa opción que ha introducido no aparece en el menú mi señor, deme otra opción:";
            const string MsgErrorAbility = "\nEl valor no es válido, vuelva a probar:";
            const string MsgErrorCharac = "\nHa introducido 3 veces un valor no válido, intentos restantes:";
            const string MsgErrorFatal = "\nHa introducido 3 veces un valor no válido, reiniciando el juego...";
            const string MsgErrorMenu = "\nHa introducido 3 veces un valor no válido, reinicie el juego.";
            const string Begin = "\n¡¡QUE EMPIECE LA BATALLA!!";
            
            //Mensajes batalla
            const string SkipExplain = "\nTutorial de la batalla:\n¿Quiere leerlo, mi señor? Pulse y";
            const string Explaining = "\nEsta batalla se basa en un sistema de turnos. Primero atacará nuestra Arquera, seguidamente, el Bárbaro, después luchará nuestra Maga, y por último, el Druida. \nEn cada turno de nuestros guerreros ha de escoger entre 3 opciones, atacar, zafarse o utilizar la habilidad especial del guerrero, esta se recargará después de 5 turnos. \nTambién tendrá que escoger la acción del Monstruo entre atacar o zafarse. \nSu misión es acabar con el monstruo, no importa que solo quede un héroe en pie, mi señor, honrará la memoria de sus compañeros caídos. \n\nAhora sí, ¡¡QUE EMPIECE LA BATALLA!!";
            const string ArcherTurn = "Turno de la arquera.";
            const string BarbarianTurn = "Turno del bárbaro.";
            const string MagicianTurn = "Turno de la maga.";
            const string DruidTurn = "Turno del druida.";
            const string MonsterTurn = "Turno del monstruo.";
            const string Turn = " ¿Qué desea que haga mi señor?";
            const string BattleOptions = "\n1. Atacar\n2. Zafarse\n3. Usar habilidad especial";
            const string SpecialAbility = " (Turnos para recargar: ";
            const string AbilityUn = "\nAún no se ha recargado la habilidad especial, mi señor, escoja otro movimiento.";
            const string BattleOptionsMons = "\n1. Atacar\n2. Zafarse";
            const string AtacArcherMsg = "\nLa Arquera ataca al monstruo generándole un daño de ";
            const string AtacBarbarianMsg = "\nEl Bárbaro ataca al monstruo generándole un daño de ";
            const string AtacMagicianMsg = "\nLa Maga ataca al monstruo generándole un daño de ";
            const string AtacDruidMsg = "\nEl Druida ataca al monstruo generándole un daño de ";
            const string ShieldArcherMsg = "\nLa Arquera mejora su escudo a un ";
            const string ShieldBarbarianMsg = "\nEl Bárbaro mejora su escudo a un ";
            const string MaxShieldBarbarianMsg = "\nEl Bárbaro ya tiene su escudo al máximo nivel. Pasemos al siguiente guerrero...";
            const string ShieldMagicianMsg = "\nLa Maga mejora su escudo a un ";
            const string ShieldDruidMsg = "\nEl Druida mejora su escudo a un ";
            const string ThirdArcherAction = "\nLa Arquera lanza su habilidad especial noqueando al monstruo durante 2 turnos.";
            const string ThirdBarbarianAction = "\nEl Bárbaro lanza su habilidad especial mejorando al máximo su escudo. No recibirá daño durante 3 turnos.";
            const string ThirdMagicianAction = "\nLa Maga lanza su habilidad especial triplicando el daño causado al monstruo con el impacto de su bola de fuego.";
            const string ThirdDruidAction = "\nEl Druida lanza su habilidad especial curando a sus aliados con 500 puntos de vida.";
            const string MonsterKnock = "\nEl monstruo está durmiendo. No atacará por ahora...";
            const string MonsterAtac = "\nEl monstruo ataca a los guerreros generándoles un daño de ";
            const string MonsterShield = "\nEl monstruo mejora su escudo a un ";
            const string WarriorOut = "\nNuestro guerrero ha caído en combate señor.";
            const string MonsterOut = "\n¡¡El monstruo ha sido derrotado!!\n¡¡VICTORIA!!";
            const string MsgKO = "\nEl monstruo ha acabado con nuestros guerreros, mi señor. Hemos sido derrotados....";


            //Constantes Personajes
            const string LifeStatic = "Vida: ";
            const string AtacStatic = "Ataque: ";
            const string ShieldStatic = "Escudo: ";
            const string Archer = "Arquera\n";
            const string ArcherAbility = "*La habilidad especial de nuestra arquera es noquear a los enemigos y les deja sin poder atacar durante 2 turnos*\nSigamos con el bárbaro:";
            const string Barbarian = "Bárbaro\n";
            const string BarbarianAbility = "*La habilidad especial de nuestro bárbaro es aumentar su defensa al 100% durante 3 turnos*\nSigamos con la maga:";
            const string Magician = "Maga\n";
            const string MagicianAbility = "*La habilidad especial de nuestra maga es disparar una bola de fuego que hace 3 veces el daño de su ataque*\nSigamos con el druida:";
            const string Druid = "Druida\n";
            const string DruidAbility = "*La habilidad especial de nuestro druida es curar 500 puntos de salud a todos nuestros héroes*\nSigamos con el monstruo al que derrotaremos:";
            const string Monster = "Monstruo\n";
            const int ArcherLifeMin = 1500, ArcherLifeMax = 2000, ArcherAtacMin = 180, ArcherAtacMax = 300, ArcherShieldMin = 25, ArcherShieldMax = 40;
            const int BarbarianLifeMin = 3000, BarbarianLifeMax = 3750, BarbarianAtacMin = 150, BarbarianAtacMax = 250, BarbarianShieldMin = 35, BarbarianShieldMax = 45;
            const int MagicianLifeMin = 1000, MagicianLifeMax = 1500, MagicianAtacMin = 300, MagicianAtacMax = 350, MagicianShieldMin = 20, MagicianShieldMax = 35, MegaShield = 100;
            const int DruidLifeMin = 2000, DruidLifeMax = 2500, DruidAtacMin = 70, DruidAtacMax = 120, DruidShieldMin = 25, DruidShieldMax = 40, Potion = 500;
            const int MonsterLifeMin = 9000, MonsterLifeMax = 12000, MonsterAtacMin = 250, MonsterAtacMax = 400, MonsterShieldMin = 20, MonsterShieldMax = 30;

            //Dibujos
            const string DeadWarrior = @"   |
===+===
   |
   |
   |
   |";
            const string DeadMonster = @"                                  |
                                ===+===
                                   |
                                   |
                                   |
                                   |";
            
            //Constantes de control
            const int Attempt = 3, Op0 = 0, Op1 = 1, Op2 = 2, Op3 = 3, Percent = 100, Two = 2;

            //Variables menú y batalla
            int option;
            string skip;

            //Variables personajes
            decimal archerLifeUser, archerLife, archerAtac;
            int archerShield, archerHability;
            decimal barbarianLifeUser, barbarianLife, barbarianAtac;
            int barbarianShield, megaShieldCD, barbarianHability;
            decimal magicianLifeUser, magicianLife, magicianAtac;
            int magicianShield, magicianHability;
            decimal druidLifeUser, druidLife, druidAtac;
            int druidShield, druidHability;
            decimal monsterLife, monsterAtac;
            int monsterShield, knock; 

            //Variables de control
            int i = 0, j = 0, k, aux = 0;

            //Menú
            do
            {
                archerLifeUser = archerAtac = archerShield = 0;
                barbarianLifeUser = barbarianAtac = barbarianShield = megaShieldCD = 0;
                magicianLifeUser = magicianAtac = magicianShield = 0;
                druidLifeUser = druidAtac = druidShield = 0;
                monsterLife = monsterAtac = monsterShield = knock = 0;
                archerHability = barbarianHability = magicianHability = druidHability = 5;
                Console.Clear();
                Console.WriteLine(Welcome);
                Console.WriteLine(Menu);
                do
                {   
                    option = Convert.ToInt32(Console.ReadLine());
                    i++;
                    if (option != Op1 && option != Op0 && i < Attempt) Console.WriteLine(MsgErrorOption);
                } while ((option != Op1 && option != Op0) && i < Attempt);
                
                //Elección personajes
                if (option == Op1)
                {
                    i = k = 0;
                    Console.Clear();
                    Console.WriteLine(ChoiceIntro);
                    Console.ReadKey();

                    //Arquera
                    while (j < Attempt && k == 0)
                    {
                        Console.WriteLine(Life + "[" + ArcherLifeMin + "-" + ArcherLifeMax + "]"); //Vida
                        while ((archerLifeUser < ArcherLifeMin || archerLifeUser > ArcherLifeMax) && i < Attempt)
                        {
                            archerLifeUser = Convert.ToDecimal(Console.ReadLine());
                            i++;
                            if ((archerLifeUser < ArcherLifeMin || archerLifeUser > ArcherLifeMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                        }
                        if (i >= Attempt)
                        {
                            Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                            j++;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {   
                            Console.Clear();
                            Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n");
                            if (j >= Attempt) j = 0;
                            i = 0;
                            Console.WriteLine(Atac + "[" + ArcherAtacMin + "-" + ArcherAtacMax + "]"); //Ataque
                            while ((archerAtac < ArcherAtacMin || archerAtac > ArcherAtacMax) && i < Attempt)
                            {
                                archerAtac = Convert.ToDecimal(Console.ReadLine());
                                i++;
                                if ((archerAtac < ArcherAtacMin || archerAtac > ArcherAtacMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                            }
                            if (i >= Attempt)
                            {
                                Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                                j++;
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n");
                                if (j >= Attempt) j = 0;
                                i = 0;
                                Console.WriteLine(Shield + "[" + ArcherShieldMin + "-" + ArcherShieldMax + "]");  //Escudo
                                while ((archerShield < ArcherShieldMin || archerShield > ArcherShieldMax) && i < Attempt)
                                {
                                    archerShield = Convert.ToInt32(Console.ReadLine());
                                    i++;
                                    if ((archerShield < ArcherShieldMin || archerShield > ArcherShieldMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                                }
                                if (i >= Attempt)
                                {
                                    Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                                    j++;
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                        }
                        if ((i >= Attempt || j >= Attempt) && (archerLifeUser < ArcherLifeMin || archerLifeUser > ArcherLifeMax)) archerLifeUser = i = 0;
                        else if ((i >= Attempt || j >= Attempt) && (archerAtac < ArcherAtacMin || archerAtac > ArcherAtacMax)) archerLifeUser = archerAtac = i = 0;
                        else if ((i >= Attempt || j >= Attempt) && (archerShield < ArcherShieldMin || archerShield > ArcherShieldMax)) archerLifeUser = archerAtac = archerShield = i = 0;
                        else if (archerLifeUser == 0 && archerAtac == 0 && archerShield == 0) j = Attempt;
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n");
                            Console.WriteLine(ArcherAbility);
                            Console.ReadKey();
                            k++;
                            i = j = 0;
                        }
                    }

                    //Bárbaro
                    while (j < Attempt && k == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n");
                        Console.WriteLine(Life + "[" + BarbarianLifeMin + "-" + BarbarianLifeMax + "]"); //Vida
                        while ((barbarianLifeUser < BarbarianLifeMin || barbarianLifeUser > BarbarianLifeMax) && i < Attempt)
                        {
                            barbarianLifeUser = Convert.ToDecimal(Console.ReadLine());
                            i++;
                            if ((barbarianLifeUser < BarbarianLifeMin || barbarianLifeUser > BarbarianLifeMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                        }
                        if (i >= Attempt)
                        {
                            Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                            j++;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian + LifeStatic + barbarianLifeUser + "\n");
                            if (j >= Attempt) j = 0;
                            i = 0;
                            Console.WriteLine(Atac + "[" + BarbarianAtacMin + "-" + BarbarianAtacMax + "]"); //Ataque
                            while ((barbarianAtac < BarbarianAtacMin || barbarianAtac > BarbarianAtacMax) && i < Attempt)
                            {
                                barbarianAtac = Convert.ToDecimal(Console.ReadLine());
                                i++;
                                if ((barbarianAtac < BarbarianAtacMin || barbarianAtac > BarbarianAtacMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                            }
                            if (i >= Attempt)
                           {
                                Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                                j++;
                                Console.ReadKey();
                                Console.Clear();
                           }
                           else
                           {
                                Console.Clear();
                                Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian + LifeStatic + barbarianLifeUser + "\n" + AtacStatic + barbarianAtac + "\n");
                                if (j >= Attempt) j = 0;
                                i = 0;
                                Console.WriteLine(Shield + "[" + BarbarianShieldMin + "-" + BarbarianShieldMax + "]");  //Escudo
                                while ((barbarianShield < BarbarianShieldMin || barbarianShield > BarbarianShieldMax) && i < Attempt)
                                {
                                    barbarianShield = Convert.ToInt32(Console.ReadLine());
                                    i++;
                                    if ((barbarianShield < BarbarianShieldMin || barbarianShield > BarbarianShieldMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                                }
                                if (i >= Attempt)
                                {
                                    Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                                    j++;
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                           }
                        }
                        if ((i >= Attempt || j >= Attempt) && (barbarianLifeUser < BarbarianLifeMin || barbarianLifeUser > BarbarianLifeMax)) barbarianLifeUser = i = 0;
                        else if ((i >= Attempt || j >= Attempt) && (barbarianAtac < BarbarianAtacMin || barbarianAtac > BarbarianAtacMax)) barbarianLifeUser = barbarianAtac = i = 0;
                        else if ((i >= Attempt || j >= Attempt) && (barbarianShield < BarbarianShieldMin || barbarianShield > BarbarianShieldMax)) barbarianLifeUser = barbarianAtac = barbarianShield = i = 0;
                        else if (barbarianLifeUser == 0 && barbarianAtac == 0 && barbarianShield == 0) j = Attempt;
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian + LifeStatic + barbarianLifeUser + "\n" + AtacStatic + barbarianAtac + "\n" + ShieldStatic + barbarianShield + "%\n");
                            Console.WriteLine(BarbarianAbility);
                            Console.ReadKey();
                            k++;
                            i = j = 0;
                        }
                    }

                    //Maga
                    while (j < Attempt && k == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian+ LifeStatic + barbarianLifeUser + "\n" + AtacStatic + barbarianAtac + "\n" + ShieldStatic + barbarianShield + "%\n");
                        Console.WriteLine(Life + "[" + MagicianLifeMin + "-" + MagicianLifeMax + "]"); //Vida
                        while ((magicianLifeUser < MagicianLifeMin || magicianLifeUser > MagicianLifeMax) && i < Attempt)
                        {
                            magicianLifeUser = Convert.ToDecimal(Console.ReadLine());
                            i++;
                            if ((magicianLifeUser < MagicianLifeMin || magicianLifeUser > MagicianLifeMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                        }
                        if (i >= Attempt)
                        {
                            Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                            j++;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian + LifeStatic + barbarianLifeUser + "\n" + AtacStatic + barbarianAtac + "\n" + ShieldStatic + barbarianShield + "%\n\n" + Magician + LifeStatic + magicianLifeUser + "\n");
                            if (j >= Attempt) j = 0;
                            i = 0;
                            Console.WriteLine(Atac + "[" + MagicianAtacMin + "-" + MagicianAtacMax + "]"); //Ataque
                            while ((magicianAtac < MagicianAtacMin || magicianAtac > MagicianAtacMax) && i < Attempt)
                            {
                                magicianAtac = Convert.ToDecimal(Console.ReadLine());
                                i++;
                                if ((magicianAtac < MagicianAtacMin || magicianAtac > MagicianAtacMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                            }
                            if (i >= Attempt)
                            {
                                Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                                j++;
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian + LifeStatic + barbarianLifeUser + "\n" + AtacStatic + barbarianAtac + "\n" + ShieldStatic + barbarianShield + "%\n\n" + Magician+ LifeStatic + magicianLifeUser + "\n" + AtacStatic + magicianAtac + "\n");
                                if (j >= Attempt) j = 0;
                                i = 0;
                                Console.WriteLine(Shield + "[" + MagicianShieldMin + "-" + MagicianShieldMax + "]");  //Escudo
                                while ((magicianShield < MagicianShieldMin || magicianShield > MagicianShieldMax) && i < Attempt)
                                {
                                    magicianShield = Convert.ToInt32(Console.ReadLine());
                                    i++;
                                    if ((magicianShield < MagicianShieldMin || magicianShield > MagicianShieldMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                                }
                                if (i >= Attempt)
                                {
                                    Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                                    j++;
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                        }
                        if ((i >= Attempt || j >= Attempt) && (magicianLifeUser < MagicianLifeMin || magicianLifeUser > MagicianLifeMax)) magicianLifeUser = i = 0;
                        else if ((i >= Attempt || j >= Attempt) && (magicianAtac < MagicianAtacMin || magicianAtac > MagicianAtacMax)) magicianLifeUser = magicianAtac = i = 0;
                        else if ((i >= Attempt || j >= Attempt) && (magicianShield < MagicianShieldMin || magicianShield > MagicianShieldMax)) magicianLifeUser = magicianAtac = magicianShield = i = 0;
                        else if (magicianLifeUser == 0 && magicianAtac == 0 && magicianShield == 0) j = Attempt;
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian + LifeStatic + barbarianLifeUser + "\n" + AtacStatic + barbarianAtac + "\n" + ShieldStatic + barbarianShield + "%\n\n" + Magician + LifeStatic + magicianLifeUser + "\n" + AtacStatic + magicianAtac + "\n" + ShieldStatic + magicianShield + "%\n\n");
                            Console.WriteLine(MagicianAbility);
                            Console.ReadKey();
                            k++;
                            i = j = 0;
                        }
                    }

                    //Druida
                    while (j < Attempt && k == 3)
                    {
                        Console.Clear();
                        Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian + LifeStatic + barbarianLifeUser + "\n" + AtacStatic + barbarianAtac + "\n" + ShieldStatic + barbarianShield + "%\n\n" + Magician + LifeStatic + magicianLifeUser + "\n" + AtacStatic + magicianAtac + "\n" + ShieldStatic + magicianShield + "%\n\n");
                        Console.WriteLine(Life + "[" + DruidLifeMin + "-" + DruidLifeMax + "]"); //Vida
                        while ((druidLifeUser < DruidLifeMin || druidLifeUser > DruidLifeMax) && i < Attempt)
                        {
                            druidLifeUser = Convert.ToDecimal(Console.ReadLine());
                            i++;
                            if ((druidLifeUser < DruidLifeMin || druidLifeUser > DruidLifeMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                        }
                        if (i >= Attempt)
                        {
                            Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                            j++;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian + LifeStatic + barbarianLifeUser + "\n" + AtacStatic + barbarianAtac + "\n" + ShieldStatic + barbarianShield + "%\n\n" + Magician + LifeStatic + magicianLifeUser + "\n" + AtacStatic + magicianAtac + "\n" + ShieldStatic + magicianShield + "%\n\n" + Druid + LifeStatic + druidLifeUser + "\n");
                            if (j >= Attempt) j = 0;
                            i = 0;
                            Console.WriteLine(Atac + "[" + DruidAtacMin + "-" + DruidAtacMax + "]"); //Ataque
                            while ((druidAtac < DruidAtacMin || druidAtac > DruidAtacMax) && i < Attempt)
                            {
                                druidAtac = Convert.ToDecimal(Console.ReadLine());
                                i++;
                                if ((druidAtac < DruidAtacMin || druidAtac > DruidAtacMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                            }
                            if (i >= Attempt)
                            {
                                Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                                j++;
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian + LifeStatic + barbarianLifeUser + "\n" + AtacStatic + barbarianAtac + "\n" + ShieldStatic + barbarianShield + "%\n\n" + Magician + LifeStatic + magicianLifeUser + "\n" + AtacStatic + magicianAtac + "\n" + ShieldStatic + magicianShield + "%\n\n" + Druid + LifeStatic + druidLifeUser + "\n" + AtacStatic + druidAtac + "\n");
                                if (j >= Attempt) j = 0;
                                i = 0;
                                Console.WriteLine(Shield + "[" + DruidShieldMin + "-" + DruidShieldMax + "]");  //Escudo
                                while ((druidShield < DruidShieldMin || druidShield > DruidShieldMax) && i < Attempt)
                                {
                                    druidShield = Convert.ToInt32(Console.ReadLine());
                                    i++;
                                    if ((druidShield < DruidShieldMin || druidShield > DruidShieldMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                                }
                                if (i >= Attempt)
                                {
                                    Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                                    j++;
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                        }
                        if ((i >= Attempt || j >= Attempt) && (druidLifeUser < DruidLifeMin || druidLifeUser > DruidLifeMax)) druidLifeUser = i = 0;
                        else if ((i >= Attempt || j >= Attempt) && (druidAtac < DruidAtacMin || druidAtac > DruidAtacMax)) druidLifeUser = druidAtac = i = 0;
                        else if ((i >= Attempt || j >= Attempt) && (druidShield < DruidShieldMin || druidShield > DruidShieldMax)) druidLifeUser = druidAtac = druidShield = i = 0;
                        else if (druidLifeUser == 0 && druidAtac == 0 && druidShield == 0) j = Attempt;
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian + LifeStatic + barbarianLifeUser + "\n" + AtacStatic + barbarianAtac + "\n" + ShieldStatic + barbarianShield + "%\n\n" + Magician + LifeStatic + magicianLifeUser + "\n" + AtacStatic + magicianAtac + "\n" + ShieldStatic + magicianShield + "%\n\n" + Druid + LifeStatic + druidLifeUser + "\n" + AtacStatic + druidAtac + "\n" + ShieldStatic + druidShield + "%\n\n");
                            Console.WriteLine(DruidAbility);
                            Console.ReadKey();
                            k++;
                            i = j = 0;
                        }
                    }

                    //Monster
                    while (j < Attempt && k == 4)
                    {
                        Console.Clear();
                        Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian + LifeStatic + barbarianLifeUser + "\n" + AtacStatic + barbarianAtac + "\n" + ShieldStatic + barbarianShield + "%\n\n" + Magician + LifeStatic + magicianLifeUser + "\n" + AtacStatic + magicianAtac + "\n" + ShieldStatic + magicianShield + "%\n\n" + Druid + LifeStatic + druidLifeUser + "\n" + AtacStatic + druidAtac + "\n" + ShieldStatic + druidShield + "%\n\n");
                        Console.WriteLine(Life + "[" + MonsterLifeMin + "-" + MonsterLifeMax + "]"); //Vida
                        while ((monsterLife < MonsterLifeMin || monsterLife > MonsterLifeMax) && i < Attempt)
                        {
                            monsterLife = Convert.ToDecimal(Console.ReadLine());
                            i++;
                            if ((monsterLife < MonsterLifeMin || monsterLife > MonsterLifeMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                        }
                        if (i >= Attempt)
                        {
                            Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                            j++;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian + LifeStatic + barbarianLifeUser + "\n" + AtacStatic + barbarianAtac + "\n" + ShieldStatic + barbarianShield + "%\n\n" + Magician + LifeStatic + magicianLifeUser + "\n" + AtacStatic + magicianAtac + "\n" + ShieldStatic + magicianShield + "%\n\n" + Druid + LifeStatic + druidLifeUser + "\n" + AtacStatic + druidAtac + "\n" + ShieldStatic + druidShield + "%\n\n" + Monster + LifeStatic + monsterLife + "\n");
                            if (j >= Attempt) j = 0;
                            i = 0;
                            Console.WriteLine(Atac + "[" + MonsterAtacMin + "-" + MonsterAtacMax + "]"); //Ataque
                            while ((monsterAtac < MonsterAtacMin || monsterAtac > MonsterAtacMax) && i < Attempt)
                            {
                                monsterAtac = Convert.ToDecimal(Console.ReadLine());
                                i++;
                                if ((monsterAtac < MonsterAtacMin || monsterAtac > MonsterAtacMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                            }
                            if (i >= Attempt)
                            {
                                Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                                j++;
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian + LifeStatic + barbarianLifeUser + "\n" + AtacStatic + barbarianAtac + "\n" + ShieldStatic + barbarianShield + "%\n\n" + Magician + LifeStatic + magicianLifeUser + "\n" + AtacStatic + magicianAtac + "\n" + ShieldStatic + magicianShield + "%\n\n" + Druid + LifeStatic + druidLifeUser + "\n" + AtacStatic + druidAtac + "\n" + ShieldStatic + druidShield + "%\n\n" + Monster + LifeStatic + monsterLife + "\n" + AtacStatic + monsterAtac + "\n");
                                if (j >= Attempt) j = 0;
                                i = 0;
                                Console.WriteLine(Shield + "[" + MonsterShieldMin + "-" + MonsterShieldMax + "]");  //Escudo
                                while ((monsterShield < MonsterShieldMin || monsterShield > MonsterShieldMax) && i < Attempt)
                                {
                                    monsterShield = Convert.ToInt32(Console.ReadLine());
                                    i++;
                                    if ((monsterShield < MonsterShieldMin || monsterShield > MonsterShieldMax) && i < Attempt) Console.WriteLine(MsgErrorAbility);
                                }
                                if (i >= Attempt)
                                {
                                    Console.WriteLine(MsgErrorCharac + (Attempt - j - 1));
                                    j++;
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                        }
                        if ((i >= Attempt || j >= Attempt) && (monsterLife < MonsterLifeMin || monsterLife > MonsterLifeMax)) monsterLife = i = 0;
                        else if ((i >= Attempt || j >= Attempt) && (monsterAtac < MonsterAtacMin || monsterAtac > MonsterAtacMax)) monsterLife = monsterAtac = i = 0;
                        else if ((i >= Attempt || j >= Attempt) && (monsterShield < MonsterShieldMin || monsterShield > MonsterShieldMax)) monsterLife = monsterAtac = monsterShield = i = 0;
                        else if (monsterLife == 0 && monsterAtac == 0 && monsterShield == 0) j = Attempt;
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(Archer + LifeStatic + archerLifeUser + "\n" + AtacStatic + archerAtac + "\n" + ShieldStatic + archerShield + "%\n\n" + Barbarian + LifeStatic + barbarianLifeUser + "\n" + AtacStatic + barbarianAtac + "\n" + ShieldStatic + barbarianShield + "%\n\n" + Magician + LifeStatic + magicianLifeUser + "\n" + AtacStatic + magicianAtac + "\n" + ShieldStatic + magicianShield + "%\n\n" + Druid + LifeStatic + druidLifeUser + "\n" + AtacStatic + druidAtac + "\n" + ShieldStatic + druidShield + "%\n\n" + Monster + LifeStatic + monsterLife + "\n" + AtacStatic + monsterAtac + "\n" + ShieldStatic + monsterShield + "%\n\n");
                            Console.WriteLine(Begin);
                            Console.ReadKey();
                            k++;
                            i = j = 0;
                        }
                    }

                    //Tutorial
                    if (k == 5)
                    {
                        Console.WriteLine(SkipExplain);
                        skip = Console.ReadLine();
                        switch (skip)
                        {
                            case "y":
                            case "Y":
                                {   
                                    Console.Clear();
                                    Console.WriteLine(Explaining);
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;
                            default:
                                Console.Clear();
                                break;
                        }

                        //Empieza la batalla
                        archerLife = archerLifeUser;
                        barbarianLife = barbarianLifeUser;
                        magicianLife = magicianLifeUser;
                        druidLife = druidLifeUser;
                        do
                        {
                            //Arquera
                            Console.Clear();
                            if (archerLife > 0)
                            {
                                Console.WriteLine(@"        .");
                                Console.WriteLine(@" .MMMM  |\      Arquera");
                                Console.WriteLine(@"/ ( ¬_¬)|_\_    Vida: " + archerLife);
                                Console.WriteLine(@"|/  |===| /     Ataque: " + archerAtac);
                                Console.WriteLine(@"'   |   |/      Escudo: " + archerShield + "%");
                                Console.WriteLine(@"   / \  '");
                            }
                            else Console.WriteLine(DeadWarrior + "\n");
                            if (barbarianLife > 0)
                            {
                                Console.WriteLine(@"         .^.");
                                Console.WriteLine(@".~~~-_   | |    Bárbaro");
                                Console.WriteLine(@"~( ¬_¬)  | |    Vida: " + barbarianLife);
                                Console.WriteLine(@" --|---""-_-""	Ataque: " + barbarianAtac);
                                Console.WriteLine(@"   |      !     Escudo: " + barbarianShield + "%");
                                Console.WriteLine(@"  / \");
                            }
                            else Console.WriteLine(DeadWarrior + "\n");
                            if (monsterLife > 0 && knock == 0)
                            {
                                Console.WriteLine(@"                                          _.-{{-,_");
                                Console.WriteLine(@"                                         /\  {   /\");
                                Console.WriteLine(@"                                        (O\\_ _//O)|_");
                                Console.WriteLine(@"                                         (__''__)  \|_         Monstruo");
                                Console.WriteLine(@"                                          WVVVVW    \/|_       Vida: " + monsterLife);
                                Console.WriteLine(@"                                         _\MMMM/     /_ /      Ataque: " + monsterAtac);
                                Console.WriteLine(@"                                       _/ ;---' _     /_/|_    Escudo: " + monsterShield);
                                Console.WriteLine(@"                                      /   \   _/      \/_ /   /\");
                                Console.WriteLine(@"                                      VVV'|  /   /     \/_    ) \");
                                Console.WriteLine(@"                                          \ VVV'      )._/_.,-'  )");
                                Console.WriteLine(@"                                          (_   \ (_   \         /");
                                Console.WriteLine(@"                                        (VVV__/(VVV__/''--····'");
                            }
                            else if (monsterLife > 0 && knock != 0)
                            {
                                Console.WriteLine(@"                                           _.-{{-,_");
                                Console.WriteLine(@"                                          /\  {   /\");
                                Console.WriteLine(@"                                    Z    (--\_ _/--)|_");
                                Console.WriteLine(@"                                      z   (__''__)  \|_         Monstruo");
                                Console.WriteLine(@"                                        .  WVVVVW    \/|_       Vida: " + monsterLife);
                                Console.WriteLine(@"                                          _\MMMM/     /_ /      Ataque: " + monsterAtac);
                                Console.WriteLine(@"                                        _/ ;---' _     /_/|_    Escudo: " + monsterShield);
                                Console.WriteLine(@"                                       /   \   _/      \/_ /   /\");
                                Console.WriteLine(@"                                       VVV'|  /   /     \/_    ) \");
                                Console.WriteLine(@"                                           \ VVV'      )._/_.,-'  )");
                                Console.WriteLine(@"                                           (_   \ (_   \         /");
                                Console.WriteLine(@"                                         (VVV__/(VVV__/''--····'");
                            }
                            else Console.WriteLine(DeadMonster);
                            if (magicianLife > 0)
                            {
                                Console.WriteLine(@" -_'_");
                                Console.WriteLine(@"_'____'_        Maga");
                                Console.WriteLine(@"/( ¬_¬) * *     Vida: " + magicianLife);
                                Console.WriteLine(@"|/ |=== (O)*	Ataque: " + magicianAtac);
                                Console.WriteLine(@"'  |    * *     Escudo: " + magicianShield + "%");
                                Console.WriteLine(@"  / \");
                                Console.WriteLine("\n");
                            }
                            else Console.WriteLine(DeadWarrior + "\n");
                            if (druidLife > 0)
                            {
                                Console.WriteLine(@" -_'_");
                                Console.WriteLine(@"_'____'(O)      Druida");
                                Console.WriteLine(@" ( ¬_¬)=|=      Vida: " + druidLife);
                                Console.WriteLine(@" --|--- |       Ataque: " + druidAtac);
                                Console.WriteLine(@"   |    |       Escudo: " + druidShield + "%");
                                Console.WriteLine(@"  / \   |");
                                Console.WriteLine("\n");
                            }
                            else Console.WriteLine(DeadWarrior + "\n");
                            if (archerLife > 0 && monsterLife > 0)
                            {
                                Console.WriteLine(ArcherTurn + Turn + BattleOptions);
                                if (archerHability != 5 && archerHability >= 0) Console.Write(SpecialAbility + (archerHability + 1) + ")\n");
                                do
                                {
                                    option = Convert.ToInt32(Console.ReadLine());
                                    i++;
                                    if ((option < Op1 || option > Op3) && i < Attempt) Console.WriteLine(MsgErrorOption);
                                    while (archerHability != 5 && option == Op3 && i < Attempt)
                                    {
                                        Console.WriteLine(AbilityUn);
                                        i++;
                                        option = Convert.ToInt32(Console.ReadLine());
                                    }
                                } while ((option < Op1 || option > Op3) && i < Attempt);

                                switch (option)
                                {
                                    case Op1:
                                        monsterLife -= archerAtac - (archerAtac * monsterShield / Percent);
                                        Console.WriteLine(AtacArcherMsg + (archerAtac - (archerAtac * monsterShield / Percent)) + ".");
                                        Console.ReadKey();
                                        i = 0;
                                        break;
                                    case Op2:
                                        archerShield *= Two;
                                        Console.WriteLine(ShieldArcherMsg + archerShield + ".");
                                        Console.ReadKey();
                                        i = 0;
                                        break;
                                    case Op3:
                                        if (archerHability == 5) knock = Two;
                                        Console.WriteLine(ThirdArcherAction);
                                        Console.ReadKey();
                                        i = 0;
                                        break;
                                }
                                if ((archerHability <= 5 && option == Op3) || (archerHability <= 4 && archerHability > 0)) archerHability--;
                                else archerHability = 5;
                            }
                            if (archerLife <= 0)
                            {
                                Console.WriteLine(ArcherTurn + WarriorOut);
                                Console.ReadKey();
                            }
                            if (monsterLife <= 0)
                            {
                                Console.Clear();
                                if (archerLife > 0)
                                {
                                    Console.WriteLine(@"        .");
                                    Console.WriteLine(@" .MMMM  |\      Arquera");
                                    Console.WriteLine(@"/ ( ¬_¬)|_\_    Vida: " + archerLife);
                                    Console.WriteLine(@"|/  |===| /     Ataque: " + archerAtac);
                                    Console.WriteLine(@"'   |   |/      Escudo: " + archerShield + "%");
                                    Console.WriteLine(@"   / \  '");
                                }
                                else Console.WriteLine(DeadWarrior + "\n");
                                if (barbarianLife > 0)
                                {
                                    Console.WriteLine(@"         .^.");
                                    Console.WriteLine(@".~~~-_   | |    Bárbaro");
                                    Console.WriteLine(@"~( ¬_¬)  | |    Vida: " + barbarianLife);
                                    Console.WriteLine(@" --|---""-_-""	Ataque: " + barbarianAtac);
                                    Console.WriteLine(@"   |      !     Escudo: " + barbarianShield + "%");
                                    Console.WriteLine(@"  / \");
                                }
                                else Console.WriteLine(DeadWarrior + "\n");
                                Console.WriteLine(DeadMonster);
                                if (magicianLife > 0)
                                {
                                    Console.WriteLine(@" -_'_");
                                    Console.WriteLine(@"_'____'_        Maga");
                                    Console.WriteLine(@"/( ¬_¬) * *     Vida: " + magicianLife);
                                    Console.WriteLine(@"|/ |=== (O)*	Ataque: " + magicianAtac);
                                    Console.WriteLine(@"'  |    * *     Escudo: " + magicianShield + "%");
                                    Console.WriteLine(@"  / \");
                                }
                                else Console.WriteLine(DeadWarrior + "\n");
                                if (druidLife > 0)
                                {
                                    Console.WriteLine(@" -_'_");
                                    Console.WriteLine(@"_'____'(O)      Druida");
                                    Console.WriteLine(@" ( ¬_¬)=|=      Vida: " + druidLife);
                                    Console.WriteLine(@" --|--- |       Ataque: " + druidAtac);
                                    Console.WriteLine(@"   |    |       Escudo: " + druidShield + "%");
                                    Console.WriteLine(@"  / \   |");
                                }
                                else Console.WriteLine(DeadWarrior + "\n");

                                Console.WriteLine(MonsterOut);
                                Console.ReadKey();
                            }
                            else
                            {
                                if (i < Attempt)
                                {
                                    i = 0;
                                    //Bárbaro
                                    Console.Clear();
                                    if (archerLife > 0)
                                    {
                                        Console.WriteLine(@"        .");
                                        Console.WriteLine(@" .MMMM  |\      Arquera");
                                        Console.WriteLine(@"/ ( ¬_¬)|_\_    Vida: " + archerLife);
                                        Console.WriteLine(@"|/  |===| /     Ataque: " + archerAtac);
                                        Console.WriteLine(@"'   |   |/      Escudo: " + archerShield + "%");
                                        Console.WriteLine(@"   / \  '");
                                    }
                                    else Console.WriteLine(DeadWarrior + "\n");
                                    if (barbarianLife > 0)
                                    {
                                        Console.WriteLine(@"         .^.");
                                        Console.WriteLine(@".~~~-_   | |    Bárbaro");
                                        Console.WriteLine(@"~( ¬_¬)  | |    Vida: " + barbarianLife);
                                        Console.WriteLine(@" --|---""-_-""	Ataque: " + barbarianAtac);
                                        Console.WriteLine(@"   |      !     Escudo: " + barbarianShield + "%");
                                        Console.WriteLine(@"  / \");
                                    }
                                    else Console.WriteLine(DeadWarrior + "\n");
                                    if (monsterLife > 0 && knock == 0)
                                    {
                                        Console.WriteLine(@"                                          _.-{{-,_");
                                        Console.WriteLine(@"                                         /\  {   /\");
                                        Console.WriteLine(@"                                        (O\\_ _//O)|_");
                                        Console.WriteLine(@"                                         (__''__)  \|_         Monstruo");
                                        Console.WriteLine(@"                                          WVVVVW    \/|_       Vida: " + monsterLife);
                                        Console.WriteLine(@"                                         _\MMMM/     /_ /      Ataque: " + monsterAtac);
                                        Console.WriteLine(@"                                       _/ ;---' _     /_/|_    Escudo: " + monsterShield);
                                        Console.WriteLine(@"                                      /   \   _/      \/_ /   /\");
                                        Console.WriteLine(@"                                      VVV'|  /   /     \/_    ) \");
                                        Console.WriteLine(@"                                          \ VVV'      )._/_.,-'  )");
                                        Console.WriteLine(@"                                          (_   \ (_   \         /");
                                        Console.WriteLine(@"                                        (VVV__/(VVV__/''--····'");
                                    }
                                    else if (monsterLife > 0 && knock != 0)
                                    {
                                        Console.WriteLine(@"                                           _.-{{-,_");
                                        Console.WriteLine(@"                                          /\  {   /\");
                                        Console.WriteLine(@"                                    Z    (--\_ _/--)|_");
                                        Console.WriteLine(@"                                      z   (__''__)  \|_         Monstruo");
                                        Console.WriteLine(@"                                        .  WVVVVW    \/|_       Vida: " + monsterLife);
                                        Console.WriteLine(@"                                          _\MMMM/     /_ /      Ataque: " + monsterAtac);
                                        Console.WriteLine(@"                                        _/ ;---' _     /_/|_    Escudo: " + monsterShield);
                                        Console.WriteLine(@"                                       /   \   _/      \/_ /   /\");
                                        Console.WriteLine(@"                                       VVV'|  /   /     \/_    ) \");
                                        Console.WriteLine(@"                                           \ VVV'      )._/_.,-'  )");
                                        Console.WriteLine(@"                                           (_   \ (_   \         /");
                                        Console.WriteLine(@"                                         (VVV__/(VVV__/''--····'");
                                    }
                                    else Console.WriteLine(DeadMonster);
                                    if (magicianLife > 0)
                                    {
                                        Console.WriteLine(@" -_'_");
                                        Console.WriteLine(@"_'____'_        Maga");
                                        Console.WriteLine(@"/( ¬_¬) * *     Vida: " + magicianLife);
                                        Console.WriteLine(@"|/ |=== (O)*	Ataque: " + magicianAtac);
                                        Console.WriteLine(@"'  |    * *     Escudo: " + magicianShield + "%");
                                        Console.WriteLine(@"  / \");
                                        Console.WriteLine("\n");
                                    }
                                    else Console.WriteLine(DeadWarrior + "\n");
                                    if (druidLife > 0)
                                    {
                                        Console.WriteLine(@" -_'_");
                                        Console.WriteLine(@"_'____'(O)      Druida");
                                        Console.WriteLine(@" ( ¬_¬)=|=      Vida: " + druidLife);
                                        Console.WriteLine(@" --|--- |       Ataque: " + druidAtac);
                                        Console.WriteLine(@"   |    |       Escudo: " + druidShield + "%");
                                        Console.WriteLine(@"  / \   |");
                                        Console.WriteLine("\n");
                                    }
                                    else Console.WriteLine(DeadWarrior + "\n");
                                    if (barbarianLife > 0 && monsterLife > 0)
                                    {
                                        Console.WriteLine(BarbarianTurn + Turn + BattleOptions);
                                        if (barbarianHability != 5 && barbarianHability >= 0) Console.Write(SpecialAbility + (barbarianHability + 1) + ")\n");
                                        do
                                        {
                                            option = Convert.ToInt32(Console.ReadLine());
                                            i++;
                                            if ((option < Op1 || option > Op3) && i < Attempt) Console.WriteLine(MsgErrorOption);
                                            while (barbarianHability != 5 && option == Op3 && i < Attempt)
                                            {
                                                Console.WriteLine(AbilityUn);
                                                i++;
                                                option = Convert.ToInt32(Console.ReadLine());
                                            }
                                        } while ((option < Op1 || option > Op3) && i < Attempt);

                                        switch (option)
                                        {
                                            case Op1:
                                                monsterLife -= barbarianAtac - (barbarianAtac * monsterShield / Percent);
                                                Console.WriteLine(AtacBarbarianMsg + (barbarianAtac - (barbarianAtac * monsterShield / Percent)) + ".");
                                                Console.ReadKey();
                                                i = 0;
                                                break;
                                            case Op2:
                                                if (barbarianShield < MegaShield)
                                                {
                                                    barbarianShield *= Two;
                                                    Console.WriteLine(ShieldBarbarianMsg + barbarianShield + ".");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine(MaxShieldBarbarianMsg);
                                                    Console.ReadKey();
                                                }
                                                i = 0;
                                                break;
                                            case Op3:
                                                if (barbarianHability == 5) megaShieldCD = 3;
                                                Console.WriteLine(ThirdBarbarianAction);
                                                Console.ReadKey();
                                                i = 0;
                                                break;
                                        }
                                        if (option == Op3 && megaShieldCD > 0)
                                        {
                                            aux = barbarianShield;
                                            barbarianShield = MegaShield;
                                        }
                                        if ((barbarianHability <= 5 && option == Op3) || (barbarianHability <= 4 && barbarianHability > 0)) barbarianHability--;
                                        else barbarianHability = 5;
                                    }
                                    if (barbarianLife <= 0)
                                    {
                                        Console.WriteLine(BarbarianTurn + WarriorOut);
                                        Console.ReadKey();
                                    }
                                    if (monsterLife <= 0)
                                    {
                                        Console.Clear();
                                        if (archerLife > 0)
                                        {
                                            Console.WriteLine(@"        .");
                                            Console.WriteLine(@" .MMMM  |\      Arquera");
                                            Console.WriteLine(@"/ ( ¬_¬)|_\_    Vida: " + archerLife);
                                            Console.WriteLine(@"|/  |===| /     Ataque: " + archerAtac);
                                            Console.WriteLine(@"'   |   |/      Escudo: " + archerShield + "%");
                                            Console.WriteLine(@"   / \  '");
                                        }
                                        else Console.WriteLine(DeadWarrior + "\n");
                                        if (barbarianLife > 0)
                                        {
                                            Console.WriteLine(@"         .^.");
                                            Console.WriteLine(@".~~~-_   | |    Bárbaro");
                                            Console.WriteLine(@"~( ¬_¬)  | |    Vida: " + barbarianLife);
                                            Console.WriteLine(@" --|---""-_-""	Ataque: " + barbarianAtac);
                                            Console.WriteLine(@"   |      !     Escudo: " + barbarianShield + "%");
                                            Console.WriteLine(@"  / \");
                                        }
                                        else Console.WriteLine(DeadWarrior + "\n");
                                        Console.WriteLine(DeadMonster);
                                        if (magicianLife > 0)
                                        {
                                            Console.WriteLine(@" -_'_");
                                            Console.WriteLine(@"_'____'_        Maga");
                                            Console.WriteLine(@"/( ¬_¬) * *     Vida: " + magicianLife);
                                            Console.WriteLine(@"|/ |=== (O)*	Ataque: " + magicianAtac);
                                            Console.WriteLine(@"'  |    * *     Escudo: " + magicianShield + "%");
                                            Console.WriteLine(@"  / \");
                                        }
                                        else Console.WriteLine(DeadWarrior + "\n");
                                        if (druidLife > 0)
                                        {
                                            Console.WriteLine(@" -_'_");
                                            Console.WriteLine(@"_'____'(O)      Druida");
                                            Console.WriteLine(@" ( ¬_¬)=|=      Vida: " + druidLife);
                                            Console.WriteLine(@" --|--- |       Ataque: " + druidAtac);
                                            Console.WriteLine(@"   |    |       Escudo: " + druidShield + "%");
                                            Console.WriteLine(@"  / \   |");
                                        }
                                        else Console.WriteLine(DeadWarrior + "\n");

                                        Console.WriteLine(MonsterOut);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        if (i < Attempt)
                                        {
                                            i = 0;
                                            //Maga
                                            Console.Clear();
                                            if (archerLife > 0)
                                            {
                                                Console.WriteLine(@"        .");
                                                Console.WriteLine(@" .MMMM  |\      Arquera");
                                                Console.WriteLine(@"/ ( ¬_¬)|_\_    Vida: " + archerLife);
                                                Console.WriteLine(@"|/  |===| /     Ataque: " + archerAtac);
                                                Console.WriteLine(@"'   |   |/      Escudo: " + archerShield + "%");
                                                Console.WriteLine(@"   / \  '");
                                            }
                                            else Console.WriteLine(DeadWarrior + "\n");
                                            if (barbarianLife > 0)
                                            {
                                                Console.WriteLine(@"         .^.");
                                                Console.WriteLine(@".~~~-_   | |    Bárbaro");
                                                Console.WriteLine(@"~( ¬_¬)  | |    Vida: " + barbarianLife);
                                                Console.WriteLine(@" --|---""-_-""	Ataque: " + barbarianAtac);
                                                Console.WriteLine(@"   |      !     Escudo: " + barbarianShield + "%");
                                                Console.WriteLine(@"  / \");
                                            }
                                            else Console.WriteLine(DeadWarrior + "\n");
                                            if (monsterLife > 0 && knock == 0)
                                            {
                                                Console.WriteLine(@"                                          _.-{{-,_");
                                                Console.WriteLine(@"                                         /\  {   /\");
                                                Console.WriteLine(@"                                        (O\\_ _//O)|_");
                                                Console.WriteLine(@"                                         (__''__)  \|_         Monstruo");
                                                Console.WriteLine(@"                                          WVVVVW    \/|_       Vida: " + monsterLife);
                                                Console.WriteLine(@"                                         _\MMMM/     /_ /      Ataque: " + monsterAtac);
                                                Console.WriteLine(@"                                       _/ ;---' _     /_/|_    Escudo: " + monsterShield);
                                                Console.WriteLine(@"                                      /   \   _/      \/_ /   /\");
                                                Console.WriteLine(@"                                      VVV'|  /   /     \/_    ) \");
                                                Console.WriteLine(@"                                          \ VVV'      )._/_.,-'  )");
                                                Console.WriteLine(@"                                          (_   \ (_   \         /");
                                                Console.WriteLine(@"                                        (VVV__/(VVV__/''--····'");
                                            }
                                            else if (monsterLife > 0 && knock != 0)
                                            {
                                                Console.WriteLine(@"                                           _.-{{-,_");
                                                Console.WriteLine(@"                                          /\  {   /\");
                                                Console.WriteLine(@"                                    Z    (--\_ _/--)|_");
                                                Console.WriteLine(@"                                      z   (__''__)  \|_         Monstruo");
                                                Console.WriteLine(@"                                        .  WVVVVW    \/|_       Vida: " + monsterLife);
                                                Console.WriteLine(@"                                          _\MMMM/     /_ /      Ataque: " + monsterAtac);
                                                Console.WriteLine(@"                                        _/ ;---' _     /_/|_    Escudo: " + monsterShield);
                                                Console.WriteLine(@"                                       /   \   _/      \/_ /   /\");
                                                Console.WriteLine(@"                                       VVV'|  /   /     \/_    ) \");
                                                Console.WriteLine(@"                                           \ VVV'      )._/_.,-'  )");
                                                Console.WriteLine(@"                                           (_   \ (_   \         /");
                                                Console.WriteLine(@"                                         (VVV__/(VVV__/''--····'");
                                            }
                                            else Console.WriteLine(DeadMonster);
                                            if (magicianLife > 0)
                                            {
                                                Console.WriteLine(@" -_'_");
                                                Console.WriteLine(@"_'____'_        Maga");
                                                Console.WriteLine(@"/( ¬_¬) * *     Vida: " + magicianLife);
                                                Console.WriteLine(@"|/ |=== (O)*	Ataque: " + magicianAtac);
                                                Console.WriteLine(@"'  |    * *     Escudo: " + magicianShield + "%");
                                                Console.WriteLine(@"  / \");
                                                Console.WriteLine("\n");
                                            }
                                            else Console.WriteLine(DeadWarrior + "\n");
                                            if (druidLife > 0)
                                            {
                                                Console.WriteLine(@" -_'_");
                                                Console.WriteLine(@"_'____'(O)      Druida");
                                                Console.WriteLine(@" ( ¬_¬)=|=      Vida: " + druidLife);
                                                Console.WriteLine(@" --|--- |       Ataque: " + druidAtac);
                                                Console.WriteLine(@"   |    |       Escudo: " + druidShield + "%");
                                                Console.WriteLine(@"  / \   |");
                                                Console.WriteLine("\n");
                                            }
                                            else Console.WriteLine(DeadWarrior + "\n");
                                            if (magicianLife > 0 && monsterLife > 0)
                                            {
                                                Console.WriteLine(MagicianTurn + Turn + BattleOptions);
                                                if (magicianHability != 5 && magicianHability >= 0) Console.Write(SpecialAbility + (magicianHability + 1) + ")\n");
                                                do
                                                {
                                                    option = Convert.ToInt32(Console.ReadLine());
                                                    i++;
                                                    if ((option < Op1 || option > Op3) && i < Attempt) Console.WriteLine(MsgErrorOption);
                                                    while (magicianHability != 5 && option == Op3 && i < Attempt)
                                                    {
                                                        Console.WriteLine(AbilityUn);
                                                        i++;
                                                        option = Convert.ToInt32(Console.ReadLine());
                                                    }

                                                } while ((option < Op1 || option > Op3) && i < Attempt);

                                                switch (option)
                                                {
                                                    case Op1:
                                                        monsterLife -= magicianAtac - (magicianAtac * monsterShield / Percent);
                                                        Console.WriteLine(AtacMagicianMsg + (magicianAtac - (magicianAtac * monsterShield / Percent)) + ".");
                                                        Console.ReadKey();
                                                        i = 0;
                                                        break;
                                                    case Op2:
                                                        magicianShield *= Two;
                                                        Console.WriteLine(ShieldMagicianMsg + magicianShield + ".");
                                                        Console.ReadKey();
                                                        i = 0;
                                                        break;
                                                    case Op3:
                                                        if (magicianHability == 5) monsterLife -= magicianAtac * 3;
                                                        Console.WriteLine(ThirdMagicianAction);
                                                        Console.ReadKey();
                                                        i = 0;
                                                        break;
                                                }
                                                if ((magicianHability <= 5 && option == Op3) || (magicianHability <= 4 && magicianHability > 0)) magicianHability--;
                                                else magicianHability = 5;
                                            }
                                            if (magicianLife <= 0)
                                            {
                                                Console.WriteLine(MagicianTurn + WarriorOut);
                                                Console.ReadKey();
                                            }
                                            if (monsterLife <= 0)
                                            {
                                                Console.Clear();
                                                if (archerLife > 0)
                                                {
                                                    Console.WriteLine(@"        .");
                                                    Console.WriteLine(@" .MMMM  |\      Arquera");
                                                    Console.WriteLine(@"/ ( ¬_¬)|_\_    Vida: " + archerLife);
                                                    Console.WriteLine(@"|/  |===| /     Ataque: " + archerAtac);
                                                    Console.WriteLine(@"'   |   |/      Escudo: " + archerShield + "%");
                                                    Console.WriteLine(@"   / \  '");
                                                }
                                                else Console.WriteLine(DeadWarrior + "\n");
                                                if (barbarianLife > 0)
                                                {
                                                    Console.WriteLine(@"         .^.");
                                                    Console.WriteLine(@".~~~-_   | |    Bárbaro");
                                                    Console.WriteLine(@"~( ¬_¬)  | |    Vida: " + barbarianLife);
                                                    Console.WriteLine(@" --|---""-_-""	Ataque: " + barbarianAtac);
                                                    Console.WriteLine(@"   |      !     Escudo: " + barbarianShield + "%");
                                                    Console.WriteLine(@"  / \");
                                                }
                                                else Console.WriteLine(DeadWarrior + "\n");
                                                Console.WriteLine(DeadMonster);
                                                if (magicianLife > 0)
                                                {
                                                    Console.WriteLine(@" -_'_");
                                                    Console.WriteLine(@"_'____'_        Maga");
                                                    Console.WriteLine(@"/( ¬_¬) * *     Vida: " + magicianLife);
                                                    Console.WriteLine(@"|/ |=== (O)*	Ataque: " + magicianAtac);
                                                    Console.WriteLine(@"'  |    * *     Escudo: " + magicianShield + "%");
                                                    Console.WriteLine(@"  / \");
                                                }
                                                else Console.WriteLine(DeadWarrior + "\n");
                                                if (druidLife > 0)
                                                {
                                                    Console.WriteLine(@" -_'_");
                                                    Console.WriteLine(@"_'____'(O)      Druida");
                                                    Console.WriteLine(@" ( ¬_¬)=|=      Vida: " + druidLife);
                                                    Console.WriteLine(@" --|--- |       Ataque: " + druidAtac);
                                                    Console.WriteLine(@"   |    |       Escudo: " + druidShield + "%");
                                                    Console.WriteLine(@"  / \   |");
                                                }
                                                else Console.WriteLine(DeadWarrior + "\n");

                                                Console.WriteLine(MonsterOut);
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                if (i < Attempt)
                                                {
                                                    i = 0;
                                                    //Druida
                                                    Console.Clear();
                                                    if (archerLife > 0)
                                                    {
                                                        Console.WriteLine(@"        .");
                                                        Console.WriteLine(@" .MMMM  |\      Arquera");
                                                        Console.WriteLine(@"/ ( ¬_¬)|_\_    Vida: " + archerLife);
                                                        Console.WriteLine(@"|/  |===| /     Ataque: " + archerAtac);
                                                        Console.WriteLine(@"'   |   |/      Escudo: " + archerShield + "%");
                                                        Console.WriteLine(@"   / \  '");
                                                    }
                                                    else Console.WriteLine(DeadWarrior + "\n");
                                                    if (barbarianLife > 0)
                                                    {
                                                        Console.WriteLine(@"         .^.");
                                                        Console.WriteLine(@".~~~-_   | |    Bárbaro");
                                                        Console.WriteLine(@"~( ¬_¬)  | |    Vida: " + barbarianLife);
                                                        Console.WriteLine(@" --|---""-_-""	Ataque: " + barbarianAtac);
                                                        Console.WriteLine(@"   |      !     Escudo: " + barbarianShield + "%");
                                                        Console.WriteLine(@"  / \");
                                                    }
                                                    else Console.WriteLine(DeadWarrior + "\n");
                                                    if (monsterLife > 0 && knock == 0)
                                                    {
                                                        Console.WriteLine(@"                                          _.-{{-,_");
                                                        Console.WriteLine(@"                                         /\  {   /\");
                                                        Console.WriteLine(@"                                        (O\\_ _//O)|_");
                                                        Console.WriteLine(@"                                         (__''__)  \|_         Monstruo");
                                                        Console.WriteLine(@"                                          WVVVVW    \/|_       Vida: " + monsterLife);
                                                        Console.WriteLine(@"                                         _\MMMM/     /_ /      Ataque: " + monsterAtac);
                                                        Console.WriteLine(@"                                       _/ ;---' _     /_/|_    Escudo: " + monsterShield);
                                                        Console.WriteLine(@"                                      /   \   _/      \/_ /   /\");
                                                        Console.WriteLine(@"                                      VVV'|  /   /     \/_    ) \");
                                                        Console.WriteLine(@"                                          \ VVV'      )._/_.,-'  )");
                                                        Console.WriteLine(@"                                          (_   \ (_   \         /");
                                                        Console.WriteLine(@"                                        (VVV__/(VVV__/''--····'");
                                                    }
                                                    else if (monsterLife > 0 && knock != 0)
                                                    {
                                                        Console.WriteLine(@"                                           _.-{{-,_");
                                                        Console.WriteLine(@"                                          /\  {   /\");
                                                        Console.WriteLine(@"                                    Z    (--\_ _/--)|_");
                                                        Console.WriteLine(@"                                      z   (__''__)  \|_         Monstruo");
                                                        Console.WriteLine(@"                                        .  WVVVVW    \/|_       Vida: " + monsterLife);
                                                        Console.WriteLine(@"                                          _\MMMM/     /_ /      Ataque: " + monsterAtac);
                                                        Console.WriteLine(@"                                        _/ ;---' _     /_/|_    Escudo: " + monsterShield);
                                                        Console.WriteLine(@"                                       /   \   _/      \/_ /   /\");
                                                        Console.WriteLine(@"                                       VVV'|  /   /     \/_    ) \");
                                                        Console.WriteLine(@"                                           \ VVV'      )._/_.,-'  )");
                                                        Console.WriteLine(@"                                           (_   \ (_   \         /");
                                                        Console.WriteLine(@"                                         (VVV__/(VVV__/''--····'");
                                                    }
                                                    else Console.WriteLine(DeadMonster);
                                                    if (magicianLife > 0)
                                                    {
                                                        Console.WriteLine(@" -_'_");
                                                        Console.WriteLine(@"_'____'_        Maga");
                                                        Console.WriteLine(@"/( ¬_¬) * *     Vida: " + magicianLife);
                                                        Console.WriteLine(@"|/ |=== (O)*	Ataque: " + magicianAtac);
                                                        Console.WriteLine(@"'  |    * *     Escudo: " + magicianShield + "%");
                                                        Console.WriteLine(@"  / \");
                                                        Console.WriteLine("\n");
                                                    }
                                                    else Console.WriteLine(DeadWarrior + "\n");
                                                    if (druidLife > 0)
                                                    {
                                                        Console.WriteLine(@" -_'_");
                                                        Console.WriteLine(@"_'____'(O)      Druida");
                                                        Console.WriteLine(@" ( ¬_¬)=|=      Vida: " + druidLife);
                                                        Console.WriteLine(@" --|--- |       Ataque: " + druidAtac);
                                                        Console.WriteLine(@"   |    |       Escudo: " + druidShield + "%");
                                                        Console.WriteLine(@"  / \   |");
                                                        Console.WriteLine("\n");
                                                    }
                                                    else Console.WriteLine(DeadWarrior + "\n");
                                                    if (druidLife > 0 && monsterLife > 0)
                                                    {
                                                        Console.WriteLine(DruidTurn + Turn + BattleOptions);
                                                        if (druidHability != 5 && druidHability >= 0) Console.Write(SpecialAbility + (druidHability + 1) + ")\n");
                                                        do
                                                        {
                                                            option = Convert.ToInt32(Console.ReadLine());
                                                            i++;
                                                            if ((option < Op1 || option > Op3) && i < Attempt) Console.WriteLine(MsgErrorOption);
                                                            while (druidHability != 5 && option == Op3 && i < Attempt)
                                                            {
                                                                Console.WriteLine(AbilityUn);
                                                                i++;
                                                                option = Convert.ToInt32(Console.ReadLine());
                                                            }

                                                        } while ((option < Op1 || option > Op3) && i < Attempt);

                                                        switch (option)
                                                        {
                                                            case Op1:
                                                                monsterLife -= druidAtac - (druidAtac * monsterShield / Percent);
                                                                Console.WriteLine(AtacDruidMsg + (druidAtac - (druidAtac * monsterShield / Percent)) + ".");
                                                                Console.ReadKey();
                                                                i = 0;
                                                                break;
                                                            case Op2:
                                                                druidShield *= Two;
                                                                Console.WriteLine(ShieldDruidMsg + druidShield + ".");
                                                                Console.ReadKey();
                                                                i = 0;
                                                                break;
                                                            case Op3:
                                                                if (druidHability == 5)
                                                                {
                                                                    archerLife += Potion;
                                                                    if (archerLife > archerLifeUser) archerLife = archerLifeUser;
                                                                    if (archerLife <= 0) archerLife = 0;
                                                                    barbarianLife += Potion;
                                                                    if (barbarianLife > barbarianLifeUser) barbarianLife = barbarianLifeUser;
                                                                    if (barbarianLife <= 0) barbarianLife = 0;
                                                                    magicianLife += Potion;
                                                                    if (magicianLife > magicianLifeUser) magicianLife = magicianLifeUser;
                                                                    if (magicianLife <= 0) magicianLife = 0;
                                                                    druidLife += Potion;
                                                                    if (druidLife > druidLifeUser) druidLife = druidLifeUser;
                                                                    if (druidLife <= 0) druidLife = 0;
                                                                }
                                                                Console.WriteLine(ThirdDruidAction);
                                                                Console.ReadKey();
                                                                i = 0;
                                                                break;
                                                        }
                                                        if ((druidHability <= 5 && option == Op3) || (druidHability <= 4 && druidHability > 0)) druidHability--;
                                                        else druidHability = 5;
                                                    }
                                                    if (druidLife <= 0)
                                                    {
                                                        Console.WriteLine(DruidTurn + WarriorOut);
                                                        Console.ReadKey();
                                                    }
                                                    if (monsterLife <= 0)
                                                    {
                                                        Console.Clear();
                                                        if (archerLife > 0)
                                                        {
                                                            Console.WriteLine(@"        .");
                                                            Console.WriteLine(@" .MMMM  |\      Arquera");
                                                            Console.WriteLine(@"/ ( ¬_¬)|_\_    Vida: " + archerLife);
                                                            Console.WriteLine(@"|/  |===| /     Ataque: " + archerAtac);
                                                            Console.WriteLine(@"'   |   |/      Escudo: " + archerShield + "%");
                                                            Console.WriteLine(@"   / \  '");
                                                        }
                                                        else Console.WriteLine(DeadWarrior + "\n");
                                                        if (barbarianLife > 0)
                                                        {
                                                            Console.WriteLine(@"         .^.");
                                                            Console.WriteLine(@".~~~-_   | |    Bárbaro");
                                                            Console.WriteLine(@"~( ¬_¬)  | |    Vida: " + barbarianLife);
                                                            Console.WriteLine(@" --|---""-_-""	Ataque: " + barbarianAtac);
                                                            Console.WriteLine(@"   |      !     Escudo: " + barbarianShield + "%");
                                                            Console.WriteLine(@"  / \");
                                                        }
                                                        else Console.WriteLine(DeadWarrior + "\n");
                                                        Console.WriteLine(DeadMonster);
                                                        if (magicianLife > 0)
                                                        {
                                                            Console.WriteLine(@" -_'_");
                                                            Console.WriteLine(@"_'____'_        Maga");
                                                            Console.WriteLine(@"/( ¬_¬) * *     Vida: " + magicianLife);
                                                            Console.WriteLine(@"|/ |=== (O)*	Ataque: " + magicianAtac);
                                                            Console.WriteLine(@"'  |    * *     Escudo: " + magicianShield + "%");
                                                            Console.WriteLine(@"  / \");
                                                        }
                                                        else Console.WriteLine(DeadWarrior + "\n");
                                                        if (druidLife > 0)
                                                        {
                                                            Console.WriteLine(@" -_'_");
                                                            Console.WriteLine(@"_'____'(O)      Druida");
                                                            Console.WriteLine(@" ( ¬_¬)=|=      Vida: " + druidLife);
                                                            Console.WriteLine(@" --|--- |       Ataque: " + druidAtac);
                                                            Console.WriteLine(@"   |    |       Escudo: " + druidShield + "%");
                                                            Console.WriteLine(@"  / \   |");
                                                        }
                                                        else Console.WriteLine(DeadWarrior + "\n");

                                                        Console.WriteLine(MonsterOut);
                                                        Console.ReadKey();
                                                    }
                                                    else
                                                    {
                                                        if (i < Attempt)
                                                        {
                                                            i = 0;
                                                            //Monster
                                                            if (monsterShield > MonsterShieldMax) monsterShield /= Two;
                                                            Console.Clear();
                                                            if (archerLife > 0)
                                                            {
                                                                Console.WriteLine(@"        .");
                                                                Console.WriteLine(@" .MMMM  |\      Arquera");
                                                                Console.WriteLine(@"/ ( ¬_¬)|_\_    Vida: " + archerLife);
                                                                Console.WriteLine(@"|/  |===| /     Ataque: " + archerAtac);
                                                                Console.WriteLine(@"'   |   |/      Escudo: " + archerShield + "%");
                                                                Console.WriteLine(@"   / \  '");
                                                            }
                                                            else Console.WriteLine(DeadWarrior + "\n");
                                                            if (barbarianLife > 0)
                                                            {
                                                                Console.WriteLine(@"         .^.");
                                                                Console.WriteLine(@".~~~-_   | |    Bárbaro");
                                                                Console.WriteLine(@"~( ¬_¬)  | |    Vida: " + barbarianLife);
                                                                Console.WriteLine(@" --|---""-_-""	Ataque: " + barbarianAtac);
                                                                Console.WriteLine(@"   |      !     Escudo: " + barbarianShield + "%");
                                                                Console.WriteLine(@"  / \");
                                                            }
                                                            else Console.WriteLine(DeadWarrior + "\n");
                                                            if (monsterLife > 0 && knock == 0)
                                                            {
                                                                Console.WriteLine(@"                                          _.-{{-,_");
                                                                Console.WriteLine(@"                                         /\  {   /\");
                                                                Console.WriteLine(@"                                        (O\\_ _//O)|_");
                                                                Console.WriteLine(@"                                         (__''__)  \|_         Monstruo");
                                                                Console.WriteLine(@"                                          WVVVVW    \/|_       Vida: " + monsterLife);
                                                                Console.WriteLine(@"                                         _\MMMM/     /_ /      Ataque: " + monsterAtac);
                                                                Console.WriteLine(@"                                       _/ ;---' _     /_/|_    Escudo: " + monsterShield);
                                                                Console.WriteLine(@"                                      /   \   _/      \/_ /   /\");
                                                                Console.WriteLine(@"                                      VVV'|  /   /     \/_    ) \");
                                                                Console.WriteLine(@"                                          \ VVV'      )._/_.,-'  )");
                                                                Console.WriteLine(@"                                          (_   \ (_   \         /");
                                                                Console.WriteLine(@"                                        (VVV__/(VVV__/''--····'");
                                                            }
                                                            else if (monsterLife > 0 && knock != 0)
                                                            {
                                                                Console.WriteLine(@"                                           _.-{{-,_");
                                                                Console.WriteLine(@"                                          /\  {   /\");
                                                                Console.WriteLine(@"                                    Z    (--\_ _/--)|_");
                                                                Console.WriteLine(@"                                      z   (__''__)  \|_         Monstruo");
                                                                Console.WriteLine(@"                                        .  WVVVVW    \/|_       Vida: " + monsterLife);
                                                                Console.WriteLine(@"                                          _\MMMM/     /_ /      Ataque: " + monsterAtac);
                                                                Console.WriteLine(@"                                        _/ ;---' _     /_/|_    Escudo: " + monsterShield);
                                                                Console.WriteLine(@"                                       /   \   _/      \/_ /   /\");
                                                                Console.WriteLine(@"                                       VVV'|  /   /     \/_    ) \");
                                                                Console.WriteLine(@"                                           \ VVV'      )._/_.,-'  )");
                                                                Console.WriteLine(@"                                           (_   \ (_   \         /");
                                                                Console.WriteLine(@"                                         (VVV__/(VVV__/''--····'");
                                                            }
                                                            else Console.WriteLine(DeadMonster);
                                                            if (magicianLife > 0)
                                                            {
                                                                Console.WriteLine(@" -_'_");
                                                                Console.WriteLine(@"_'____'_        Maga");
                                                                Console.WriteLine(@"/( ¬_¬) * *     Vida: " + magicianLife);
                                                                Console.WriteLine(@"|/ |=== (O)*	Ataque: " + magicianAtac);
                                                                Console.WriteLine(@"'  |    * *     Escudo: " + magicianShield + "%");
                                                                Console.WriteLine(@"  / \");
                                                                Console.WriteLine("\n");
                                                            }
                                                            else Console.WriteLine(DeadWarrior + "\n");
                                                            if (druidLife > 0)
                                                            {
                                                                Console.WriteLine(@" -_'_");
                                                                Console.WriteLine(@"_'____'(O)      Druida");
                                                                Console.WriteLine(@" ( ¬_¬)=|=      Vida: " + druidLife);
                                                                Console.WriteLine(@" --|--- |       Ataque: " + druidAtac);
                                                                Console.WriteLine(@"   |    |       Escudo: " + druidShield + "%");
                                                                Console.WriteLine(@"  / \   |");
                                                                Console.WriteLine("\n");
                                                            }
                                                            else Console.WriteLine(DeadWarrior + "\n");
                                                            if (monsterLife > 0 && (archerLife > 0 || barbarianLife > 0 || magicianLife > 0 || druidLife > 0))
                                                            {
                                                                Console.Write(MonsterTurn);
                                                                if (knock == 0)
                                                                {
                                                                    Console.WriteLine(Turn + BattleOptionsMons);
                                                                    do
                                                                    {
                                                                        option = Convert.ToInt32(Console.ReadLine());
                                                                        i++;
                                                                        if ((option != Op1 && option != Op2) && i < Attempt) Console.WriteLine(MsgErrorOption);
                                                                    } while ((option != Op1 && option != Op2) && i < Attempt);

                                                                    switch (option)
                                                                    {
                                                                        case Op1:
                                                                            if (archerLife > 0) archerLife -= monsterAtac - (monsterAtac * archerShield / Percent);
                                                                            else archerShield = Percent;
                                                                            if (barbarianLife > 0) barbarianLife -= monsterAtac - (monsterAtac * barbarianShield / Percent);
                                                                            else barbarianShield = Percent;
                                                                            if (magicianLife > 0) magicianLife -= monsterAtac - (monsterAtac * magicianShield / Percent);
                                                                            else magicianShield = Percent;
                                                                            if (druidLife > 0) druidLife -= monsterAtac - (monsterAtac * druidShield / Percent);
                                                                            else druidShield = Percent;
                                                                            Console.WriteLine(MonsterAtac + (monsterAtac - (monsterAtac * archerShield / Percent)) + ", " + (monsterAtac - (monsterAtac * barbarianShield / Percent)) + ", " + (monsterAtac - (monsterAtac * magicianShield / Percent)) + ", " + (monsterAtac - (monsterAtac * druidShield / Percent)) + ".");
                                                                            Console.ReadKey();
                                                                            i = 0;
                                                                            break;
                                                                        case Op2:
                                                                            monsterShield *= Two;
                                                                            Console.WriteLine(MonsterShield + monsterShield + ".");
                                                                            Console.ReadKey();
                                                                            i = 0;
                                                                            break;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    knock--;
                                                                    Console.WriteLine(MonsterKnock);
                                                                    Console.ReadKey();
                                                                }
                                                            }
                                                            if (megaShieldCD <= 3 && megaShieldCD >= 0) megaShieldCD--;
                                                        }
                                                    }
                                                    if (archerShield > ArcherShieldMax) archerShield /= Two;
                                                    if (barbarianShield > BarbarianShieldMax && megaShieldCD < 0) barbarianShield /= Two;
                                                    if (barbarianShield == MegaShield && megaShieldCD <= 0) barbarianShield = aux;
                                                    if (magicianShield > MagicianShieldMax) magicianShield /= Two;
                                                    if (druidShield > DruidShieldMax) druidShield /= Two;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        } while ((archerLife > 0 || barbarianLife > 0 || magicianLife > 0 || druidLife > 0) && monsterLife > 0 && i < Attempt);
                        if (archerLife <= 0 && barbarianLife <= 0 && magicianLife <= 0 && druidLife <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine(DeadWarrior + "\n");
                            Console.WriteLine(DeadWarrior + "\n");
                            Console.WriteLine(@"                                          _.-{{-,_");
                            Console.WriteLine(@"                                         /\  {   /\");
                            Console.WriteLine(@"                                        (O\\_ _//O)|_");
                            Console.WriteLine(@"                                         (__''__)  \|_         Monstruo");
                            Console.WriteLine(@"                                          WVVVVW    \/|_       Vida: " + monsterLife);
                            Console.WriteLine(@"                                         _\MMMM/     /_ /      Ataque: " + monsterAtac);
                            Console.WriteLine(@"                                       _/ ;---' _     /_/|_    Escudo: " + monsterShield);
                            Console.WriteLine(@"                                      /   \   _/      \/_ /   /\");
                            Console.WriteLine(@"                                      VVV'|  /   /     \/_    ) \");
                            Console.WriteLine(@"                                          \ VVV'      )._/_.,-'  )");
                            Console.WriteLine(@"                                          (_   \ (_   \         /");
                            Console.WriteLine(@"                                        (VVV__/(VVV__/''--····'");
                            Console.WriteLine(DeadWarrior + "\n");
                            Console.WriteLine(DeadWarrior + "\n");
                            Console.WriteLine(MsgKO);
                            Console.ReadKey();
                        }
                        option = Op1;
                    }
                }
                else
                {
                    if (option == Op0) Console.WriteLine(Bye);
                    else Console.WriteLine(MsgErrorMenu);
                }
                if ((j >= Attempt || i >= Attempt) && option == Op1)
                {
                    Console.WriteLine(MsgErrorFatal);
                    j = i = 0;
                    option = Op1;
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (option == Op1 && j < Attempt);
        }
    }
}