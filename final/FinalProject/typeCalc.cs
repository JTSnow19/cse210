//TypeCalcLive
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class typeCalc
{
    public Dictionary<string, List<string>> typeChartDefense(string filename)
    {
        Dictionary<string, List<string>> typeDefense = new Dictionary<string, List<string>>();
        using (var csvReader = new StreamReader(filename))
        {
            csvReader.ReadLine(); // Skip header row
            while (!csvReader.EndOfStream)
            {
                var line = csvReader.ReadLine().Split(',');
                var type = line[1];
                var defenseValues = cleanedData(line);
                typeDefense[type] = defenseValues;
            }
        }
        return typeDefense;
    }

    public Dictionary<string, List<string>> typeChartOffense(string filename, Dictionary<string, List<string>> typeDefense)
    {
        Dictionary<string, List<string>> typeOffense = new Dictionary<string, List<string>>();
        int keyCount = 0;
        using (var csvReader = new StreamReader(filename))
        {
            csvReader.ReadLine(); // Skip header row
            while (!csvReader.EndOfStream)
            {
                var line = csvReader.ReadLine();
                var parts = line.Split(',');
                var attackingType = parts[1];
                if (typeDefense.ContainsKey(attackingType))
                {
                    var offenseValues = cleanedData(parts);
                    typeOffense[typeDefense.Keys.ElementAt(keyCount)] = offenseValues;
                    keyCount++;
                }
                else if (string.IsNullOrEmpty(attackingType) || string.IsNullOrEmpty(line) || line == "Attacking Type")
                {
                    continue;
                }
                else
                {
                    var offenseValues = cleanedData(parts);
                    typeOffense[attackingType] = offenseValues;
                }
            }
        }
        return typeOffense;
    }


    public List<string> cleanedData(string[] data)
    {
        List<string> useful = new List<string>();
        int itemCount = 0;
        while (itemCount != 20)
        {
            if (itemCount <= 1)
            {
                itemCount++;
            }
            else if (itemCount > 1)
            {
                string item;
                switch (data[itemCount])
                {
                    case "1Ã—":
                        item = "1x";
                        break;
                    case "Â½Ã—":
                        item = "0.5x";
                        break;
                    case "2Ã—":
                        item = "2x";
                        break;
                    case "0Ã—":
                        item = "0x";
                        break;
                    default:
                        item = data[itemCount];
                        break;
                }
                useful.Add(item);
                itemCount++;
            }
            else
            {
                Console.WriteLine("not working");
            }
        }
        return useful;
    }
    static int RandomNumber() 
    {
        Random random = new Random();
        return random.Next(1, 893);
    }
    public void pokeDexInfo(string[] args)
    {
        Dictionary<string, List<string>> typeDefense = typeChartDefense("typeChart.csv");
        Dictionary<string, List<string>> typeOffense = typeChartOffense("typeChart.csv", typeDefense);

        int number = RandomNumber();
        Dictionary<string, string[]> pokeDict = retriveMons();
        string numberReturn = number.ToString();
        if (pokeDict.ContainsKey(numberReturn))
        {
            string[] selectedPokemon = pokeDict[numberReturn];
            Console.WriteLine(selectedPokemon[0]); // Print the Pokemon name
            string type1 = selectedPokemon[1];
            string type2 = selectedPokemon[2];
            string pokemon = selectedPokemon[0];

            List<string> typeR = weaknessList(typeOffense, typeDefense, type1);
            List<string> typeR2 = weaknessList(typeOffense, typeDefense, type2);

            var (immune, resist_05, neutral_damage, double_damage, resist_25, quad_damage) = typeRelation(typeR, typeR2, typeDefense);

            Console.WriteLine($"For the type combo of {type1.ToUpper()} and {type2.ToUpper()}:");
            Console.WriteLine($"Immune to: {string.Join(", ", immune)}");
            Console.WriteLine($"Takes double damage from: {string.Join(", ", double_damage)}");
            Console.WriteLine($"Takes quadruple damage from {string.Join(", ", quad_damage)}");
            Console.WriteLine($"Takes neutral damage from: {string.Join(", ", neutral_damage)}");
            Console.WriteLine($"Resists: {string.Join(", ", resist_05)}");
            Console.WriteLine($"Heavily Resists: {string.Join(", ", resist_25)}");
        }
    }



    static Dictionary<string, string[]> retriveMons()
    {
        // I think I will be moving this code, or repurposing it


        throw new NotImplementedException();


    }

    static List<string> weaknessList(Dictionary<string, List<string>> typeOffense, Dictionary<string, List<string>> typeDefense, string type)
    {
        return typeOffense[type];
    }

    public static (List<string>, List<string>, List<string>, List<string>, List<string>, List<string>) typeRelation(List<string> typeR, List<string> typeR2, Dictionary<string, List<string>> typeDefense)
    {
        List<string> immune = new List<string>();
        List<string> resist_05 = new List<string>();
        List<string> neutral_damage = new List<string>();
        List<string> double_damage = new List<string>();
        List<string> resist_25 = new List<string>();
        List<string> quad_damage = new List<string>();

        foreach (var type in typeR)
        {
            switch (type)
            {
                case "0x":
                    immune.Add(typeDefense.Keys.ElementAt(Array.IndexOf(typeDefense.Values.ToArray(), typeR)));
                    break;
                case "0.5x":
                    resist_05.Add(typeDefense.Keys.ElementAt(Array.IndexOf(typeDefense.Values.ToArray(), typeR)));
                    break;
                case "1x":
                    neutral_damage.Add(typeDefense.Keys.ElementAt(Array.IndexOf(typeDefense.Values.ToArray(), typeR)));
                    break;
                case "2x":
                    double_damage.Add(typeDefense.Keys.ElementAt(Array.IndexOf(typeDefense.Values.ToArray(), typeR)));
                    break;
                case "0.25x":
                    resist_25.Add(typeDefense.Keys.ElementAt(Array.IndexOf(typeDefense.Values.ToArray(), typeR)));
                    break;
                case "4x":
                    quad_damage.Add(typeDefense.Keys.ElementAt(Array.IndexOf(typeDefense.Values.ToArray(), typeR)));
                    break;
            }
        }

        foreach (var type in typeR2)//alt click is so helpful for conversion
        {
            switch (type)
            {
                case "0x":
                    immune.Add(typeDefense.Keys.ElementAt(Array.IndexOf(typeDefense.Values.ToArray(), typeR2)));
                    break;
                case "0.5x":
                    resist_05.Add(typeDefense.Keys.ElementAt(Array.IndexOf(typeDefense.Values.ToArray(), typeR2)));
                    break;
                case "1x":
                    neutral_damage.Add(typeDefense.Keys.ElementAt(Array.IndexOf(typeDefense.Values.ToArray(), typeR2)));
                    break;
                case "2x":
                    double_damage.Add(typeDefense.Keys.ElementAt(Array.IndexOf(typeDefense.Values.ToArray(), typeR2)));
                    break;
                case "0.25x":
                    resist_25.Add(typeDefense.Keys.ElementAt(Array.IndexOf(typeDefense.Values.ToArray(), typeR2)));
                    break;
                case "4x":
                    quad_damage.Add(typeDefense.Keys.ElementAt(Array.IndexOf(typeDefense.Values.ToArray(), typeR2)));
                    break;
            }
        }

        return (immune, resist_05, neutral_damage, double_damage, resist_25, quad_damage);
    }
    } //current end

//gonna have to rewrite a bunch...
//    public List<string> WeaknessList(Dictionary<string, List<string> offense, List<string> defense, string typeInput>)
//    {
//        List<string> typeRelations = new List<string>();
//        typeInput = typeInput.ToUpper();
//        if (defense.Contains(typeInput))
//        {
//            int typeIndex = defense.IndexOf(typeInput);
//
//            foreach (KeyValuePair<string, List<string>> item in offense)
//            {
//                string relation = item.Value[typeIndex];
//                typeRelations.Add(relation);
//            }
//        }
//
//        return typeRelations;
////    }
//
//    public List< (List<string>, List<string>, List<string>, List<string>, List<string>, List<string>)> TypeRelation(List<string> tp1, List<string> tp2, List<string> typeList)
//    {
//        List<string> relation25x = new List<string>(); // the specifications aren't completely needed, but they allow for flexibility and reusability in the future
//        List<string> relation05x = new List<string>();
//        List<string> relation1x = new List<string>();
//        List<string> relation2x = new List<string>();
//        List<string> relation4x = new List<string>();
//        List<string> relation0x = new List<string>();
//        int iC = 0;
//        while (iC != 18)
//        {
//            if (tp2.Count == 0)
//            {
//                if (tp1[iC] == "0x")
//                {
//                    relation0x.Add(typeList[iC]);
//                    iC++;
//                }
//                else if (tp1[iC] == "0.5x")
//                {
//                    relation05x.Add(typeList[iC]);
//                    iC++;
//                }
//                else if (tp1[iC] == "1x")
//                {
//                    relation1x.Add(typeList[iC]);
//                    iC++;
//                }
//                else if (tp1[iC] == "2x")
//                {
//                    relation2x.Add(typeList[iC]);
//                    iC++;
//                }
//            }
//            else
//            {
//                if (tp1[iC] == "0x" || tp2[iC] == "0x")
//                {
//                    relation0x.Add(typeList[iC]);
//                    iC++;
//                }
//                else if (tp1[iC] == "0.5x" && tp2[iC] == "0.5x")
//                {
//                    relation25x.Add(typeList[iC]);
//                    iC++;
//                }
//                else if (tp1[iC] == "1x" && tp2[iC] == "1x")
//                {
//                    relation1x.Add(typeList[iC]);
//                    iC++;
//                }
//                else if (tp1[iC] == "2x" && tp2[iC] == "2x")
//                {
//                    relation4x.Add(typeList[iC]);
//                    iC++;
//                }
//                else if (tp1[iC] == "0.5x" && tp2[iC] == "1x")
//                {
//                    relation05x.Add(typeList[iC]);
//                    iC++;
//                }
//                else if (tp1[iC] == "2x" && tp2[iC] == "1x")
//                {
//                    relation2x.Add(typeList[iC]);
//                    iC++;
//                }
//                else if (tp1[iC] == "2x" && tp2[iC] == "0.5x")
//                {
//                    relation1x.Add(typeList[iC]);
//                    iC++;
//                }
//                else
//                {
//                    (tp1[iC], tp2[iC]) = (tp2[iC], tp1[iC]); // swaps the list items so I don't have to rewrite the entire thing twice
//                }
//            }
//        }
//
//        return [relation0x, relation05x, relation1x, relation2x, relation25x, relation4x];
//    }


