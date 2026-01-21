


using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnaaa
{
    internal class Program
    {
        static void Operation10(string[] DNA) // operation 10 finding codon sequence.
        {
            bool flag = false;
            Console.Write("Codon sequence: ");
            string codonSeq = Console.ReadLine();
            string[] codonsArray = new string[56];
            string[] codons = codonSeq.Split(' ');
            Console.Write("Starting from: ");
            int start = Convert.ToInt16(Console.ReadLine()) - 1;
            for (int i = start; i < DNA.Length; i++)
            {
                int k = 0;
                while (k != (codons.Length))
                {
                    if (codons[k] != DNA[i + k])
                    {
                        k = 0;
                        break;
                    }
                    k++;
                }
                if (k == codons.Length)
                {
                    Console.WriteLine("Result: " + (i + 1));
                    flag = true;
                }
            }
            if (flag == false)
                Console.WriteLine("Result: -1 (Not found)");

        }



        static string find_gender(string[] dna_codons) // for operation 17
        {
            string gender = "XY";
            if (dna_codons[1] == "TTT" && dna_codons[2] == "AAA" || dna_codons[1] == "TTT" && dna_codons[2] == "TTT" || dna_codons[1] == "AAA" && dna_codons[2] == "AAA" || dna_codons[1] == "AAA" && dna_codons[2] == "TTT")
            {
                gender = "XX";
            }

            else
                gender = "XY";
            return gender;
        }

        static string randblob() // this func to make true random BLOB dna.
        {
            int numberofgenes, numberofcodons, amount;
            string gene, start, stopp, randomgene, dnastrand3, dnastrand, stop1;

            string[] codons = new string[] { "GCT", "GCC", "GCA", "GCG", "CGT", "CGC", "CGA", "CGG", "AGA", "AGG", "AAT", "AAC", "GAT", "GAC", "TGT", "TGC", "CAA", "CAG", "GAA", "GAG", "GGT", "GGC", "GGA", "GGG", "CAT", "CAC", "ATT", "ATC", "ATA", "CTT", "CTC", "CTA", "CTG", "TTA", "TTG", "AAA", "AAG", "TTT", "TTC", "CCT", "CCC", "CCA", "CCG", "TCT", "TCC", "TCA", "TCG", "AGC", "ACT", "ACC", "ACA", "ACG", "TGG", "TAT", "TAC", "GTT", "GTC", "GTA", "GTG", "TAA", "TGA", "TAG", "ATG" };
            string[] stop = new string[] { "TAA", "TAG", "TGA" };
            string[] gender = new string[] { "GGG", "CCC", "AAA", "TTT" };
            char[] nucleotids = new char[] { 'A', 'C', 'G', 'T' };

            Random rand = new Random();
            int no = rand.Next(0, stop.Length);
            stopp = stop[no];
            stop1 = "TAG";
            start = "ATG";
            int forgenderx = rand.Next(2, 4);
            string gen1 = start + gender[forgenderx] + gender[forgenderx] + stop1;
            int forgendery = rand.Next(0, 2);
            string gen2 = start + gender[forgenderx] + gender[forgendery] + stop1;
            string[] genderselect = new string[] { gen1, gen2 };
            int genderselect1 = rand.Next(0, genderselect.Length);
            numberofgenes = rand.Next(1, 6);
            gene = genderselect[genderselect1];
            for (int i = 0; i <= numberofgenes; i++)
            {
                numberofcodons = rand.Next(1, 6);
                gene = gene + start;
                for (int j = 0; j <= numberofcodons; j++)
                {
                    amount = rand.Next(0, 60);
                    gene = gene + codons[amount];
                }
                gene = gene + stopp;
            }
            return gene;
        }


        static string to_write(string[] codons)
        {
            string dna_3 = "";
            for (int i = 0; i < codons.Length; i++) 
            {
                dna_3 = dna_3 + codons[i] + " ";

            }
            return dna_3;
        }

        static void Main(string[] args)
        {
            int numberofgenes, numberofcodons, amount;
            string gene, start, stopp, randomgene, dnastrand3, dnastrand, stop1;

            string[] aminoacids = new string[] { "Ala", "Ala", "Ala", "Ala", "Arg", "Arg", "Arg", "Arg", "Arg", "Arg", "Asn", "Asn", "Asp", "Asp", "Cys", "Cys", "Gln", "Gln", "Glu", "Glu", "Gly", "Gly", "Gly", "Gly", "His", "His", "Ile", "Ile", "Ile", "Leu", "Leu", "Leu", "Leu", "Leu", "Leu", "Lys", "Lys", "Phe", "Phe", "Pro", "Pro", "Pro", "Pro", "Ser", "Ser", "Ser", "Ser", "Ser", "Ser", "Thr", "Thr", "Thr", "Thr", "Trp", "Tyr", "Tyr", "Val", "Val", "Val", "Val", "END", "END", "END", "Met" };
            string[] codons = new string[] { "GCT", "GCC", "GCA", "GCG", "CGT", "CGC", "CGA", "CGG", "AGA", "AGG", "AAT", "AAC", "GAT", "GAC", "TGT", "TGC", "CAA", "CAG", "GAA", "GAG", "GGT", "GGC", "GGA", "GGG", "CAT", "CAC", "ATT", "ATC", "ATA", "CTT", "CTC", "CTA", "CTG", "TTA", "TTG", "AAA", "AAG", "TTT", "TTC", "CCT", "CCC", "CCA", "CCG", "TCT", "TCC", "TCA", "TCG", "AGT", "AGC", "ACT", "ACC", "ACA", "ACG", "TGG", "TAT", "TAC", "GTT", "GTC", "GTA", "GTG", "TAA", "TGA", "TAG", "ATG" };
            string[] stop = new string[] { "TAA", "TAG", "TGA" };
            string[] gender = new string[] { "GGG", "CCC", "AAA", "TTT" };
            char[] nucleotids = new char[] { 'A', 'C', 'G', 'T' };



            //OP 3
            Random rand = new Random();
            int no = rand.Next(0, stop.Length);
            stopp = stop[no];
            stop1 = "TAG";
            start = "ATG";
            int forgenderx = rand.Next(2, 4);
            string gen1 = start + gender[forgenderx] + gender[forgenderx] + stop1;
            int forgendery = rand.Next(0, 2);
            string gen2 = start + gender[forgenderx] + gender[forgendery] + stop1;
            string[] genderselect = new string[] { gen1, gen2 };
            int genderselect1 = rand.Next(0, genderselect.Length);
            numberofgenes = rand.Next(1, 6);
            gene = genderselect[genderselect1];
            for (int i = 0; i <= numberofgenes; i++)
            {
                numberofcodons = rand.Next(1, 6);
                gene = gene + start;
                for (int j = 0; j <= numberofcodons; j++)
                {
                    amount = rand.Next(0, 60);
                    gene = gene + codons[amount];
                }
                gene = gene + stopp;
            }
            randomgene = start;
            int randomgenecodon = rand.Next(0, 4);
            for (int y = 0; y < randomgenecodon; y++)
            {
                int randomgenee = rand.Next(0, 4);
                randomgene = randomgene + gender[randomgenee];
            }
            randomgene = randomgene + stopp;
            int numberofrandomgenes = rand.Next(0, 8);
            for (int t = 0; t <= numberofrandomgenes; t++)
            {
                int numberofrandomcodons = rand.Next(0, 9);
                for (int p = 0; p <= numberofrandomcodons; p++)
                {
                    amount = rand.Next(0, 64);
                    randomgene = randomgene + codons[amount];
                }
            }
            string[] generand = new string[] { gene, randomgene };
            int generand1 = rand.Next(0, generand.Length);
            dnastrand3 = generand[generand1];


            Console.WriteLine("     ***********File upload MENU***********");
            Console.WriteLine("Please enter 1 if you want to upload DNA from file,\nPlease enter 2 if you want to enter DNA,\nPlease enter 3 for computer to generate DNA.");
            Console.WriteLine("***************************************************");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
            switch (choice)
            {
                //OP 1
                case 1:
                    string dnastrand1 = System.IO.File.ReadAllText("C:\\Users\\doaec\\Desktop\\08.11.2022lab.txt");


                    dnastrand = dnastrand1;
                    Console.WriteLine("DNA strand: " + dnastrand);
                    break;
                //OP 2
                case 2:
                    Console.WriteLine("Please enter DNA sequence");
                    string dnastrand2 = Console.ReadLine();

                    dnastrand = dnastrand2;
                    Console.WriteLine("DNA strand: " + dnastrand);
                    break;
                case 3:
                    dnastrand = dnastrand3;
                    Console.WriteLine("DNA strand: " + dnastrand);
                    break;
                default:
                    dnastrand = dnastrand3;
                    Console.WriteLine("DNA strand: " + dnastrand);
                    break;
            }

            char[] dna = new char[dnastrand.Length];
            for (int i = 0; i < dnastrand.Length; i++)
            {
                dna[i] = dnastrand[i]; // our new char dna
            }





            Console.WriteLine("Operations MENU: ");
            Console.WriteLine("4) Check DNA gene structure");
            Console.WriteLine("5) Check DNA of BLOB organism");
            Console.WriteLine("6) Produce complement of a DNA sequence");
            Console.WriteLine("7) Determine amino acids");
            Console.WriteLine("8) Delete codons (delete n codons, starting from mth codon) ");
            Console.WriteLine("9) Insert codons (insert a codon sequence, starting from mth codon)");
            Console.WriteLine("10) Find codons (find a codon sequence, starting from mth codon) ");
            Console.WriteLine("11) Reverse codons (reverse n codons, starting from mth codon) ");
            Console.WriteLine("12) Find the number of genes in a DNA strand ");
            Console.WriteLine("13) Find the shortest gene in a DNAstrand) ");
            Console.WriteLine("14) Find the longest gene in a DNA strand) ");
            Console.WriteLine("15) Find the most repeated n-nucleotide sequence in a DNA stran) ");
            Console.WriteLine("16) Hydrogen bond statistics for a DNA strand");
            Console.WriteLine("17) Make 10 generations of BLOB on Mars");


            string again = "yes";

            while (again == "yes" || again == "Yes" || again == "YES")
            {

                Console.WriteLine();
                Console.Write("Enter your operation number: ");
                int oprt = Convert.ToInt32(Console.ReadLine());

                switch (oprt)

                {
                    case 4:
                        {
                            //OP 4
                            int control = 0; // we create a control variable to skip through if statements.
                            if (dna.Length % 3 == 0)// checks if the dna is made from codons(3 nucleotids)
                            {
                                control++;
                            }
                            else
                            {
                                Console.WriteLine("Codon structure error");// stops when it isn't.
                                break;
                            }
                            if (control == 1)// if the dna is made out of codons(3 nucleotids)
                            {
                                if (dna[0] == 'A' && dna[1] == 'T' && dna[2] == 'G')// if the dna starts with a start codon.
                                {
                                    control++;
                                }
                                else
                                {
                                    control -= 2;
                                }
                            }
                            if (control == 2)// if the dna starts with a start codon.
                            {
                                //if the dna ends with a stop codon.
                                if ((dna[dna.Length - 3] == 'T' && dna[dna.Length - 2] == 'G' && dna[dna.Length - 1] == 'A') || (dna[dna.Length - 3] == 'T' && dna[dna.Length - 2] == 'A' && dna[dna.Length - 1] == 'A') || (dna[dna.Length - 3] == 'T' && dna[dna.Length - 2] == 'A' && dna[dna.Length - 1] == 'G'))
                                {
                                    control++;
                                }
                                else
                                {
                                    control -= 3;
                                }
                            }
                            if (control == 3)// if the dna starts and ends with the right codons.
                            {
                                int counter = 0;// we create a counter variable to check if the start and stop codon numbers in the dna are equal.
                                for (int i = 3; i < dna.Length - 3; i += 3)
                                {
                                    if (dna[i] == 'A' && dna[i + 1] == 'T' && dna[i + 2] == 'G')
                                    {
                                        counter++;
                                    }
                                    if ((dna[i] == 'T' && dna[i + 1] == 'G' && dna[i + 2] == 'A') || (dna[i] == 'T' && dna[i + 1] == 'A' && dna[i + 2] == 'A') || (dna[i] == 'T' && dna[i + 1] == 'A' && dna[i + 2] == 'G'))
                                    {
                                        counter--;
                                    }
                                }
                                if (counter == 0)// if the start and stop codon numbers in the dna are equal.
                                {
                                    control++;
                                }
                                else
                                {
                                    control -= 4;
                                }
                            }
                            if (control == 4)// if the dna starts and ends with the right codons, the number of start and stop codons are equal.
                            {
                                for (int i = 3; i < dna.Length - 3; i += 3)
                                {
                                    if (dna[i] == 'A' && dna[i + 1] == 'T' && dna[i + 2] == 'G')// if there is another start codon after the first start codon.
                                    {
                                        for (int k = 3; k < i; k += 3)
                                        {
                                            // if there is a stop codon before the last stop codon.
                                            if ((dna[k] == 'T' && dna[k + 1] == 'G' && dna[k + 2] == 'A') || (dna[k] == 'T' && dna[k + 1] == 'A' && dna[k + 2] == 'A') || (dna[k] == 'T' && dna[k + 1] == 'A' && dna[k + 2] == 'G'))
                                            {
                                                if (dna[k + 3] == dna[i])// if the stop codon comes right before the start codon.
                                                {
                                                    control++;

                                                }
                                                else
                                                {
                                                    control -= 5;

                                                }
                                            }
                                            else
                                            {
                                                control -= 5;

                                            }
                                        }
                                    }
                                    else
                                    {
                                        control++;

                                    }
                                }
                            }
                            if (control >= 0)
                            {
                                Console.WriteLine("Gene structure is ok");
                            }
                            else if (control <= 0)
                            {
                                Console.WriteLine("Gene structure error");
                            }

                            break;
                        }
                    //OP 5
                    case 5:
                        {
                            int z = 3;
                            for (int u = 0; u < dna.Length - 5; u = u + 3) //For the case of start-stop codons neighbhour to each other in DNA mean number of codons
                            {
                                if ((dna[u] == 'A' && dna[u + 1] == 'T' && dna[u + 2] == 'G') && ((dna[u + 3] == 'T' && dna[u + 4] == 'G' && dna[u + 5] == 'A') || (dna[u + 3] == 'T' && dna[u + 4] == 'A' && dna[u + 5] == 'A') || (dna[u + 3] == 'T' && dna[u + 4] == 'A' && dna[u + 5] == 'G')))
                                {
                                    z = 0;
                                }
                                else
                                {
                                    z = 1;// mean number of codons ok.
                                }
                            }


                            if (dna.Length % 3 != 0) //Control number of codons 
                            {
                                Console.WriteLine("Codon structure error.");
                            }

                            else if (dna.Length < 21 || dna.Length > 167) // Control number of Dna nucleotids
                            {
                                Console.WriteLine("Dna structure error");
                            }
                            else if (!(dna[0] == 'A' && dna[1] == 'T' && dna[2] == 'G' && dna[9] == 'T' && dna[10] == 'A' && dna[11] == 'G')) // Control for gender gen
                            {
                                Console.Write("Gender error.");

                            }
                            else if (!(dna[3] == dna[4] && dna[4] == dna[5] && dna[6] == dna[7] && dna[8] == dna[7])) //Control the genderss is same AAA TTT GGG CCC
                            {
                                Console.Write("Gender error.");
                            }
                            else if (z == 0)
                            {
                                Console.Write("Number of codons error.");

                            }
                            else
                            {
                                int countstar = 0;
                                int countfinish = 0;

                                for (int i = 0; i < dna.Length - 2; i = i + 3)
                                {
                                    char[] atg = { 'A', 'T', 'G' };
                                    char[] tag = { 'T', 'A', 'G' };
                                    char[] tga = { 'T', 'G', 'A' };
                                    char[] taa = { 'T', 'A', 'A' };
                                    if (dna[i] == atg[0] && dna[i + 1] == atg[1] && dna[i + 2] == atg[2])// if we have ATG our counterstar will be +1
                                    {
                                        countstar++;
                                    }
                                    else if ((dna[i] == tag[0] && dna[i + 1] == tag[1] && dna[i + 2] == tag[2]) || dna[i] == taa[0] && dna[i + 1] == taa[1] && dna[i + 2] == taa[2] || dna[i] == tga[0] && dna[i + 1] == tga[1] && dna[i + 2] == tga[2])
                                    {
                                        countfinish++; //if we have TAA or TAG or TGA our counterfinish will be +1
                                    }
                                }
                                if (countstar != countfinish) // when we check our counters  if the start and end codon numbers are not equal genes errror.
                                {
                                    Console.WriteLine("Number of genes error.");
                                }
                                else
                                {
                                    Console.WriteLine("BLOB is OK.");
                                }

                            }

                            break;

                        }
                    case 6:
                        {          //OP 6

                            string[] dna_codons = new string[dna.Length / 3];
                            for (int i = 0; i < dna.Length; i += 3)
                                dna_codons[i / 3] = "" + dna[i] + dna[i + 1] + dna[i + 2];

                            int k = 0;
                            dna = new char[dna_codons.Length * 3];
                            for (int i = 0; i < dna_codons.Length; i++)
                            {
                                string temp = dna_codons[i];// For example dna_codons[0] =ATG iw will be temp=ATG then we 
                                if (temp == "")             // We will divide temp by 3 and assign it as char
                                    break;
                                dna[k] = temp[0];
                                dna[k + 1] = temp[1];
                                dna[k + 2] = temp[2];
                                k += 3;

                            }
                            Console.WriteLine("Dna strand   : " + to_write(dna_codons));
                            for (int i = 0; i < dna.Length; i++)
                            {
                                if (dna[i] == 'A') // such that In order to get complement in the dna char array, we throw the reverse
                                {
                                    dna[i] = 'T';
                                }
                                else if (dna[i] == 'T')
                                {
                                    dna[i] = 'A';
                                }
                                else if (dna[i] == 'G')
                                {
                                    dna[i] = 'C';
                                }
                                else if (dna[i] == 'C')
                                {
                                    dna[i] = 'G';
                                }


                            }



                            dna_codons = new string[dna.Length / 3]; //we convert char to triple string
                            for (int i = 0; i < dna.Length; i += 3)
                                dna_codons[i / 3] = "" + dna[i] + dna[i + 1] + dna[i + 2];

                            Console.WriteLine("New dna strand: " + to_write(dna_codons));
                            break;

                        }
                    case 7:
                        {  //OP 7

                            string[] dna_codons = new string[dna.Length / 3];
                            for (int i = 0; i < dna.Length; i += 3)
                                dna_codons[i / 3] = "" + dna[i] + dna[i + 1] + dna[i + 2];

                            Console.WriteLine("Dna strand  : " + to_write(dna_codons));
                            Console.Write("Amino acids : ");

                            for (int i = 0; i < dna_codons.Length; i++)
                            {
                                for (int j = 0; j < codons.Length; j++) //it checks our codons and prints the corresponding amino acid
                                {
                                    if (dna_codons[i] == codons[j])
                                        Console.Write(aminoacids[j] + " "); //our aminoacids on line 87
                                }

                            }

                            Console.WriteLine();
                            break;

                        }
                    case 8:
                        {

                            string[] dna_codons = new string[dna.Length / 3];
                            for (int i = 0; i < dna.Length; i += 3)
                                dna_codons[i / 3] = "" + dna[i] + dna[i + 1] + dna[i + 2];

                            Console.WriteLine("Please enter an n to determine the number of codons to be deleted: "); // taking how many codons will be delete
                            int num_codons = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Please enter starting codon m: ");
                            int start_codon = Convert.ToInt32(Console.ReadLine()); // taking from user starting from which codon
                            Console.WriteLine("Dna strand: " + to_write(dna_codons)); // our function to write dna like that ATG TTT ATA...
                            Console.WriteLine("Delete " + num_codons + " codons, starting from " + start_codon);

                            for (int i = start_codon - 1; i < dna_codons.Length - num_codons; i++)
                                dna_codons[i] = dna_codons[i + num_codons]; //the algorithm of this code is assigned as many backwards as the number of codons to be added and the last codons are not included in the sequence.
                            for (int i = dna_codons.Length - num_codons; i < dna_codons.Length; i++)
                                dna_codons[i] = "";

                            Console.WriteLine("New DNA strand: " + to_write(dna_codons));
                            break;
                        }
                    case 9:
                        {
                            //OP 9

                            string[] dna_codons = new string[dna.Length / 3];
                            for (int i = 0; i < dna.Length; i += 3)
                                dna_codons[i / 3] = "" + dna[i] + dna[i + 1] + dna[i + 2];

                            Console.WriteLine("Please enter m: ");
                            int strt = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter the codon sequence you would like to add: ");
                            string eDNA = Console.ReadLine();
                            Console.WriteLine("Add " + eDNA + " to the dna , starting from " + strt);
                            Console.WriteLine("DNA strand: " + to_write(dna_codons));

                            string[] temp_dna_codons = new string[dna_codons.Length];//we copy our original dna
                            for (int i = 0; i < dna_codons.Length; i++)
                                temp_dna_codons[i] = dna_codons[i];


                            dna_codons = new string[dna_codons.Length + eDNA.Length / 3];//size of dna increases as we will add codons
                            for (int i = 0; i < temp_dna_codons.Length; i++)
                                dna_codons[i] = temp_dna_codons[i];

                            string[] edna_codons = new string[eDNA.Length / 3];
                            for (int i = 0; i < eDNA.Length; i += 3)
                            {
                                string tstring = "";
                                tstring = "" + eDNA[i] + eDNA[i + 1] + eDNA[i + 2];
                                edna_codons[i / 3] = tstring; //The added dna came as a char, so we converted it to a triple string.
                            }

                            string[] temp = new string[dna_codons.Length - strt];
                            int k = 0;
                            for (int i = strt - 1; i < dna_codons.Length - strt; i++) //we get codon from original dna up to where the insertion is
                            {
                                if (dna_codons[i] == "")
                                    break;
                                temp[k] = dna_codons[i];
                                k++;
                            }
                            k = 0;
                            for (int i = strt - 1; i <= strt - 2 + edna_codons.Length; i++)//we add the dna to be added
                            {
                                dna_codons[i] = edna_codons[k];
                                k++;
                            }
                            k = 0;
                            for (int i = strt - 1 + edna_codons.Length; i < dna_codons.Length; i++)
                            {
                                dna_codons[i] = temp[k]; //After adding the new dna, we add the original dna
                                k++;
                            }



                            Console.WriteLine("New DNA strand: " + to_write(dna_codons));
                            break;

                        }
                    case 10:
                        {
                            string[] dna_codons = new string[dna.Length / 3];
                            for (int i = 0; i < dna.Length; i += 3)
                                dna_codons[i / 3] = "" + dna[i] + dna[i + 1] + dna[i + 2];

                            Operation10(dna_codons);
                            break;

                            break;
                        }
                    case 11:
                        {
                            //OP 11

                            string[] dna_codons = new string[dna.Length / 3];
                            for (int i = 0; i < dna.Length; i += 3)
                                dna_codons[i / 3] = "" + dna[i] + dna[i + 1] + dna[i + 2];
                            Console.WriteLine(to_write(dna_codons));


                            Console.Write("starting from? : ");
                            int startt = Convert.ToInt32(Console.ReadLine());
                            Console.Write("reverse n codons ? : ");
                            int number = Convert.ToInt32(Console.ReadLine());
                            string[] temp_array = new string[number]; //We open an array as many as the number of codons to reverse
                            for (int i = 0; i < number; i++)
                                temp_array[i] = dna_codons[i + startt - 1];//for take to temp
                            int k = temp_array.Length - 1;//the last  indeks
                            for (int i = startt - 1; i < startt + number - 1; i++)
                            {
                                dna_codons[i] = temp_array[k]; //the last codon will be replaced by the leading i index increases while k index decreases
                                k--;
                            }
                            Console.WriteLine("Your new DNA: " + to_write(dna_codons));
                            break;
                        }
                    case 12:
                        {

                            string[] dna_codons = new string[dna.Length / 3];
                            for (int i = 0; i < dna.Length; i += 3)
                                dna_codons[i / 3] = "" + dna[i] + dna[i + 1] + dna[i + 2];

                            int sayac = 0;

                            for (int i = 0; i < dna_codons.Length; i++) // if the start and end codons are equal, our gene number will be equal to the start codon number
                            {
                                for (int j = 0; j < dna_codons.Length; j++)
                                    if (dna_codons[i] == "ATG" && (dna_codons[j] == "TAG" || dna_codons[j] == "TGA" || dna_codons[j] == "TAA"))
                                        sayac++;
                                break;
                            }

                            Console.WriteLine(to_write(dna_codons));
                            Console.WriteLine("Number of genes: " + sayac);
                            Console.ReadLine();

                            break;
                        }
                    case 13:
                        {

                            string[] dna_codons = new string[dna.Length / 3];
                            for (int i = 0; i < dna.Length; i += 3)
                                dna_codons[i / 3] = "" + dna[i] + dna[i + 1] + dna[i + 2];

                            Console.WriteLine(to_write(dna_codons));
                            int ATGin = -1;
                            int stopIn = -1;
                            int min = 9;
                            int ATGmin = -1;
                            int genNum = 0;
                            int genMin = 0;
                            string shortestGen = "";
                            int starttt = 0; // for save position of min dna

                            for (int i = 0; i < dna_codons.Length; i++)
                            {
                                switch (dna_codons[i])
                                {
                                    case "ATG":
                                        ATGin = i;
                                        break;
                                    case "TAG":
                                        stopIn = i;
                                        break;
                                    case "TAA":
                                        stopIn = i;
                                        break;
                                    case "TGA":
                                        stopIn = i;
                                        break;
                                }
                                if (ATGin < stopIn)// according to the status of the start and end codons
                                {
                                    genNum++;
                                    int codonNum = stopIn - ATGin + 1; // for find how many codon  gen
                                    if (codonNum < min)
                                    {
                                        genMin = genNum;
                                        min = codonNum;
                                        ATGmin = ATGin;
                                        starttt = ATGin + 1;
                                    }
                                }
                            }

                            if (genNum == 0)
                            {
                                Console.WriteLine("There's no any gen in this DNA codon.");
                            }
                            else
                            {
                                for (int k = 0; k < min; k++)
                                {
                                    shortestGen += dna_codons[ATGmin + k] + " ";
                                }

                                Console.WriteLine("Shortest gene:  " + shortestGen);
                                Console.WriteLine("Number of codonds in the gene: " + min);
                                Console.WriteLine("Position of the gene: " + starttt);
                            }






                            break;
                        }
                    case 14:
                        {
                            string[] dna_codons = new string[dna.Length / 3];
                            for (int i = 0; i < dna.Length; i += 3)
                                dna_codons[i / 3] = "" + dna[i] + dna[i + 1] + dna[i + 2];


                            Console.WriteLine(to_write(dna_codons));
                            int ATGin = -1;
                            int stopIn = -1;
                            int max = 1;
                            int ATGmin = -1;
                            int genNum = 0;
                            int genMax = 0;
                            string longestGen = "";
                            int startt = 0;
                            for (int i = 0; i < dna_codons.Length; i++)
                            {
                                switch (dna_codons[i])
                                {
                                    case "ATG":
                                        ATGin = i;
                                        break;
                                    case "TAG":
                                        stopIn = i;
                                        break;
                                    case "TAA":
                                        stopIn = i;
                                        break;
                                    case "TGA":
                                        stopIn = i;
                                        break;
                                }
                                if (ATGin < stopIn) //means that if the start codon comes before the end codons
                                {
                                    genNum++;
                                    int codonNum = stopIn - ATGin + 1;
                                    if (codonNum > max)  //more codon number means longer gene
                                    {
                                        genMax = genNum;
                                        max = codonNum;
                                        ATGmin = ATGin;
                                        startt = ATGin + 1;
                                    }
                                }
                            }

                            if (genNum == 0)
                            {
                                Console.WriteLine("There's no any gen in this DNA codon.");
                            }
                            else
                            {
                                for (int k = 0; k < max; k++)
                                {
                                    longestGen += dna_codons[ATGmin + k] + " ";
                                }

                                Console.WriteLine("Longest gene:  " + longestGen);
                                Console.WriteLine("Number of codonds in the gene: " + max);
                                Console.WriteLine("Position of the gene: " + startt);
                            }
                            break;
                        }
                    case 15:
                        {
                            Console.Write("Enter the number of the nucleotide: ");
                            int numofnuc = Convert.ToInt32(Console.ReadLine());    //we take the length of the sequence we would like to find from the user.
                            int p = numofnuc;
                            string q = "                                                                                                                       ";

                            char[] qchar = new char[numofnuc];
                            qchar = q.ToCharArray();

                            string w = "                                                                                                                       ";

                            char[] storeq = new char[numofnuc];
                            storeq = w.ToCharArray();

                            string z = "                                                                                                                       ";

                            char[] storeq2 = new char[numofnuc];
                            storeq2 = z.ToCharArray();                                // we opened 3 arrays to assign the dna lengths we will encounter to them.
                            int counter1 = 0;
                            int counter2 = 0;
                            int counter3 = 0;
                            int counter4 = 0;
                            int y = 0;
                            for (int i = 0; i < dna.Length - (numofnuc); i++)     // first, we choose a length that is the same as numofnuc, and then we look at how often the sequence repeats itself.
                            {
                                if (counter2 == 0)
                                {
                                    
                                        qchar[0] = dna[i];
                                        for (int k = 1; k < numofnuc; k++)
                                        {
                                            qchar[k] = dna[i + k];
                                        }
                                        numofnuc = p;                    // we keep a value as much as numofnuc inside the qchar array.
                                        for (int h = i + numofnuc; h < dna.Length - numofnuc; h++)
                                        {
                                            counter1 = 0;
                                            if (qchar[0] == dna[h])       // we compare the length we have inside the qchar to dna.
                                            {
                                                counter1 = 1;
                                                for (int j = 1; j < numofnuc; j++)
                                                {
                                                    if ((dna[h + j] == qchar[j]))
                                                    {
                                                        counter1++;
                                                    }
                                                }
                                            }
                                            if (counter1 == numofnuc)           //if the dna has the nucleotide we have in qchar, we increase the counter.
                                            {
                                                counter2++;
                                                h += numofnuc - 1;
                                            }
                                            numofnuc = p;
                                        
                                    }
                                    for (int b = 0; b < numofnuc; b++)
                                    {
                                        storeq[b] = qchar[b];             // we transfer the value inside qchar to storeq so that it stays permanent.
                                    }
                                }
                                else if (counter4 == 0)
                                {
                                    
                                    
                                        qchar[0] = dna[i];
                                        for (int k = 1; k < numofnuc; k++)
                                        {
                                            qchar[k] = dna[i + k];
                                        }
                                        numofnuc = p;
                                        for (int h = i + numofnuc; h < dna.Length - numofnuc; h++)
                                        {
                                            counter3 = 0;
                                            if (qchar[0] == dna[h])
                                            {
                                                counter3 = 1;
                                                for (int j = 1; j < numofnuc; j++)
                                                {
                                                    if ((dna[h + j] == qchar[j]))
                                                    {
                                                        counter3++;
                                                    }
                                                }
                                            }
                                            if (counter3 == numofnuc)
                                            {
                                                counter4++;
                                                h += numofnuc - 1;
                                            }
                                            numofnuc = p;
                                        }
                                    
                                    for (int b = 0; b < numofnuc; b++)
                                    {
                                        storeq2[b] = qchar[b];
                                    }
                                }
                                if (counter2 >= counter4)              //  we reset counter4 if counter2 is greater and start comparing a new nucleotide to the one we have inside counter2.
                                {
                                    counter4 = 0;
                                }
                                else if (counter4 > counter2)
                                {
                                    counter2 = 0;
                                }
                            }
                            if (counter2 > counter4)
                            {
                                Console.Write("Most repeated sequance: ");
                                for (int i = 0; i < numofnuc; i++)
                                {
                                    Console.Write(storeq[i]);         // the code outputs counter2 when its the most repeated sequence.
                                }
                                Console.WriteLine();
                                Console.WriteLine("Frequency : " + (counter2 + 1));
                            }
                            else if (counter4 >= counter2)
                            {
                                Console.Write("Most repeated sequance: ");
                                for (int i = 0; i < numofnuc; i++)
                                {
                                    Console.Write(storeq2[i]);
                                }
                                Console.WriteLine();
                                Console.WriteLine("Frequency : " + (counter4 + 1));
                            }
                            else
                            {
                                Console.Write("Most repeated sequance: NONE ");
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 16:
                        {
                            string[] dna_codons = new string[dna.Length / 3];
                            for (int i = 0; i < dna.Length; i += 3)
                                dna_codons[i / 3] = "" + dna[i] + dna[i + 1] + dna[i + 2];

                            int hydrogene_bond = 0;
                            int hydrogenebonds2 = 0;
                            int hydrogenebonds3 = 0;
                            for (int i = 0; i < dna.Length; i++)
                            {
                                if (dna[i] == 'A' || dna[i] == 'T') //If there is an A or T nucleotide, there is 2 times the number of hydrogen
                                {
                                    hydrogenebonds2++;
                                }
                                else if (dna[i] == 'G' || dna[i] == 'C')//If there is an C or G nucleotide, there is 3 times the number of hydrogen
                                {
                                    hydrogenebonds3++;
                                }
                            }
                            hydrogene_bond += (2 * hydrogenebonds2 + 3 * hydrogenebonds3);
                            Console.WriteLine(to_write(dna_codons));
                            Console.WriteLine("Number of pairings with 2 hydrogene codons: " + hydrogenebonds2);
                            Console.WriteLine("Number of pairings with 3 hydrogene codons: " + hydrogenebonds3);
                            Console.WriteLine("Number of hydrogene bonds: " + hydrogene_bond);
                            break;
                        }
                    case 17:
                        {
                            string[] dna_codons = new string[dna.Length / 3];
                            for (int i = 0; i < dna.Length; i += 3)
                                dna_codons[i / 3] = "" + dna[i] + dna[i + 1] + dna[i + 2];

                            string[] blob1 = dna_codons;
                            for (int a = 1; a <= 10; a++)
                            {

                                string[] blob2;
                                string[] blob3 = new string[70];
                                do
                                {


                                    string blob2_string = randblob(); //thıs ıs our random blob func.
                                    blob2 = new string[blob2_string.Length / 3];
                                    for (int i = 0; i < blob2_string.Length; i += 3)
                                        blob2[i / 3] = "" + blob2_string[i] + blob2_string[i + 1] + blob2_string[i + 2];//We converted it to 3 strings blob2

                                } while (find_gender(blob2) == find_gender(blob1)); //we used our function to make the genders look different

                                blob3[0] = "ATG";
                                blob3[1] = blob1[1];
                                blob3[2] = blob2[2];
                                blob3[3] = "TAG";
                                int countblob1 = 0;
                                int countblob2 = 0;
                                for (int i = 0; i < blob1.Length; i++)
                                {
                                    if (blob1[i] == "ATG")
                                        countblob1++;                    // to know how many gene there is
                                }
                                for (int i = 0; i < blob2.Length; i++)
                                {
                                    if (blob2[i] == "ATG")
                                        countblob2++;
                                }
                                int max = 0;
                                if (blob2.Length < blob1.Length) // 3. Finding the long sequence for DNA
                                    max = countblob1;
                                else
                                    max = countblob2;

                                string[] bigger_array = new string[9];//
                                if (blob1.Length < blob2.Length)
                                    bigger_array = blob2;
                                else
                                    bigger_array = blob1;

                                int adding_number = 4;

                                for (int k = 2; k <= max; k++)
                                {
                                    if (k % 2 == 0 && k <= countblob1)//Since we get codons with ordinal multiples from blob 1
                                    {
                                        string[] temp = new string[blob1.Length];

                                        int number = 0;
                                        for (int i = 0; i < blob1.Length; i += 1)
                                        {
                                            temp = new string[blob1.Length];
                                            if (blob1[i] == "ATG")
                                            {

                                                for (int j = 0; j < blob1.Length; j += 1)
                                                {
                                                    temp[j] = blob1[j + i];
                                                    if (blob1[j + i] == "TGA" || blob1[j + i] == "TAA" || blob1[j + i] == "TAG")
                                                    {
                                                        number++;

                                                        break;
                                                    }
                                                }
                                            }
                                            if (number == k)
                                                break;

                                        }
                                        for (int j = 0; j < 10; j++)
                                        {
                                            blob3[adding_number] = temp[j];
                                            adding_number++;
                                            if (temp[j] == "TAG" || temp[j] == "TAA" || temp[j] == "TGA")
                                                break;
                                        }
                                    }
                                    else if (k % 2 == 1 && k <= countblob2)
                                    {
                                        string[] temp = new string[blob2.Length];

                                        int gen_line = 0;
                                        for (int i = 0; i < blob2.Length; i += 1)
                                        {
                                            temp = new string[blob2.Length];
                                            if (blob2[i] == "ATG")
                                            {

                                                for (int j = 0; j < blob2.Length; j += 1)
                                                {
                                                    temp[j] = blob2[j + i];//appends codons between start and end
                                                    if (blob2[j + i] == "TGA" || blob2[j + i] == "TAA" || blob2[j + i] == "TAG")
                                                    {
                                                        gen_line++;

                                                        break;
                                                    }
                                                }
                                            }
                                            if (gen_line == k) // which gene should be situation
                                                break;

                                        }
                                        for (int j = 0; j < 10; j++)
                                        {
                                            blob3[adding_number] = temp[j];
                                            adding_number++;
                                            if (temp[j] == "TAG" || temp[j] == "TAA" || temp[j] == "TGA")
                                                break;
                                        }

                                    }
                                    else   // this else will now receive the remaining genes from the longer codon
                                    {

                                        for (int j = k; j <= max; j += 1)
                                        {
                                            string[] temp = new string[bigger_array.Length];

                                            int number = 0;
                                            for (int i = 0; i < bigger_array.Length; i += 1)
                                            {
                                                temp = new string[bigger_array.Length];// for the newly added gene
                                                if (bigger_array[i] == "ATG")
                                                {

                                                    for (int g = 0; g < bigger_array.Length; g += 1)
                                                    {
                                                        temp[g] = bigger_array[g + i];
                                                        if (bigger_array[g + i] == "TGA" || bigger_array[g + i] == "TAA" || bigger_array[g + i] == "TAG")
                                                        {
                                                            number++;

                                                            break;
                                                        }
                                                    }
                                                }
                                                if (number == k)
                                                    break;
                                            }

                                            for (int p = 0; p < 150; p += 1)
                                            {
                                                blob3[adding_number] = temp[p];
                                                adding_number += 1;
                                                if (temp[p] == "TAG" || temp[p] == "TAA" || temp[p] == "TGA")
                                                    break;
                                            }
                                        }
                                        break;
                                    }
                                }
                                int counter = 0;
                                for (int i = 0; i < blob3.Length; i += 1)
                                {
                                    if (blob3[i] == "GGG" || blob3[i] == "CCC" || blob3[i] == "CGC" || blob3[i] == "CCG" || blob3[i] == "GCC" || blob3[i] == "CGG" || blob3[i] == "GCG" || blob3[i] == "GGC")
                                        counter++; // to calculate ratio
                                }
                                int countblob3 = 0;
                                for (int i = 0; i < blob3.Length; i++)
                                {

                                    if (blob3[i] == null)
                                        break;
                                    countblob3++;
                                }
                                double ratio = ((double)counter / (countblob3)) * 100;


                                Console.WriteLine("Generation  " + a);
                                Console.WriteLine("BLOB1-" + find_gender(blob1) + " : " + to_write(blob1));
                                Console.WriteLine("BLOB2-" + find_gender(blob2) + " : " + to_write(blob2));
                                Console.WriteLine("BLOB3-" + find_gender(blob3) + " : " + to_write(blob3));
                                Console.WriteLine("BLOB3 faulty codons ratio = " + counter + "/" + (countblob3) + " = " + ratio + "%");
                                if (ratio >= 10)
                                {
                                    Console.WriteLine("Newborn dies. Generations are over.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    blob1 = blob3;
                                    Console.ReadLine();
                                }
                            }
                        }
                        break;


                }

            }
            Console.WriteLine();
            Console.Write("do you want to do another operation :yes or no? ");

            again = Console.ReadLine();
            Console.WriteLine();
        }
    }
}

