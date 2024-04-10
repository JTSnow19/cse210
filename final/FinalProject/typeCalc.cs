//TypeCalcLive
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class typeCalc
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



    public List<string> WeaknessList(Dictionary<string, List<string>> typeOffense, Dictionary<string, List<string>> typeDefense, string type)
    {
        return typeOffense[type];
    }

    public static List<string> TypeRelation(List<string> typeR, List<string> typeR2, Dictionary<string, List<string>> typeDefense)
    {
        List<string> immune = new List<string>();
        List<string> resist_05 = new List<string>();
        List<string> neutral_damage = new List<string>();
        List<string> double_damage = new List<string>();
        List<string> resist_25 = new List<string>();
        List<string> quad_damage = new List<string>();
        List<string> mergeWeakness = new List<string>();

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
        mergeWeakness.AddRange(quad_damage);
        mergeWeakness.AddRange(double_damage); //I would like to apologive for the improper naming schemas, here old converted code and all that
        return mergeWeakness;
    }
     //current end

    public bool Outcome(Dictionary<string, List<string>> playerTeam, string chosenMon,List<string> opponent){
       //string chosenMon=SelectedForBattle();
        Dictionary<string, List<string>> typeDefense = typeChartDefense("typeChart.csv");
        Dictionary<string, List<string>> typeOffense = typeChartOffense("typeChart.csv", typeDefense);
       List<string> opponentWeakness = WeaknessList(typeOffense,typeDefense,opponent[1]);
       List<string> opponentWeakness2 = WeaknessList(typeOffense,typeDefense,opponent[2]);
       List<string> relations = TypeRelation(opponentWeakness, opponentWeakness2, typeDefense); //it seems that there is some leanency with how it calculates but its pretty fun
        if (playerTeam.ContainsKey(chosenMon)){
            List<string> hitsEffective = playerTeam[chosenMon];

            
            foreach (var item in hitsEffective.GetRange(1, 2))
                {
                    if (relations.Contains(item))
                    {
                        return false;
                    }
                }
        }
        
        return true;
        }
            
            
            
            
    }

