using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TreasuresSoC
{
    public partial class Form1 : Form
    {
        string[] fullAfStats = { "burn_immunity", "strike_immunity",
            "shock_immunity", "telepatic_immunity", "chemical_burn_immunity", "explosion_immunity",
            "fire_wound_immunity"};
        string[] fullAfStats2 = { "radiation_restore_speed", "health_restore_speed",
            "power_restore_speed", "bleeding_restore_speed" };
        string[] fullOutfitStats = { "burn_protection", "strike_protection", "shock_protection",
            "wound_protection", "radiation_protection", "telepatic_protection", "chemical_burn_protection",
            "explosion_protection", "fire_wound_protection"};
        string[] fullOutfitImmunities = { "burn_immunity", "strike_immunity", "shock_immunity",
            "wound_immunity", "radiation_immunity", "telepatic_immunity", "chemical_burn_immunity",
            "explosion_immunity", "fire_wound_immunity"};
        //список имен файлов
        string[] nameList = {"other", "af", "ammo", "item", "model",
            "outfit", "sound", "weapon", "npcexception", "community"};

        List<string> errList;
        List<string> loadedDataList;
        List<TextBox> textBoxList;
        List<CheckBox> generateTypeCheckBoxList;
        List<Label> recommendLabelList;

        Random rnd;

        public bool isSaved = false;

        public Form1()
        {
            errList = new List<string>();
            loadedDataList = new List<string>();
            rnd = new Random();

            InitializeComponent();

            textBoxList = new List<TextBox>() { otherTextBox, afTextBox, ammoTextBox, itemTextBox,
                modelTextBox, armorTextBox, soundTextBox, weaponTextBox,
                npcExecptTextBox, communityTextBox};

            generateTypeCheckBoxList = new List<CheckBox>() { treasureCheckBox, afCheckBox,
                weaponCheckBox, armorCheckBox, npcCheckBox };

            recommendLabelList = new List<Label>() { recommendLabel1, recommendLabel2, recommendLabel3,
                recommendLabel4};
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string changedLists = "";
            List<string> files = new List<string>();
            List<string> info = new List<string>();
            List<int> indexes = new List<int>();

            //проходим по всем спискам и ищем отличия от кешированных данных
            for (int i = 0; i < loadedDataList.Count; i++)
            {
                if (loadedDataList[i] != textBoxList[i].Text)
                {
                    changedLists += nameList[i] + ", ";
                    files.Add(nameList[i]);
                    info.Add(textBoxList[i].Text);
                    indexes.Add(i);
                }
            }

            if (files.Count < 1)
            {
                return;
            }

            SaveForm form = new SaveForm(files, info, this);
            form.ShowDialog();

            if (isSaved)
            {
                for (int i = 0; i < indexes.Count; i++)
                {
                    loadedDataList[indexes[i]] = textBoxList[indexes[i]].Text;
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            loadLists(false);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            bool isNeedCreate = false;

            foreach (CheckBox cb in generateTypeCheckBoxList)
            {
                if (cb.Checked)
                {
                    isNeedCreate = true;
                    break;
                }
            }

            if (!isNeedCreate)
            {
                return;
            }

            string originalConfPath = "./rndata/default/gamedata/config";
            string datetime = DateTime.Now.ToString().Replace(':', '-').Replace('/', '.');
            string newGamedataPath = $"./gamedata {datetime}";
            string confDir;
            //создание директорий
            try
            {
                confDir = Directory.CreateDirectory($"{newGamedataPath}/config").FullName;
                Directory.CreateDirectory($"{newGamedataPath}/config/scripts");
                Directory.CreateDirectory($"{newGamedataPath}/scripts");
                Directory.CreateDirectory($"{newGamedataPath}/spawns");
            }
            catch
            {
                (new ErrForm("Ошибка создания директории gamedata. Проверьте права доступа на запись. Операция прервана.")).ShowDialog();
                return;
            }
            //тайники
            try
            {
                if (treasureCheckBox.Checked)
                {
                    List<string> outfitList = new List<string>(armorTextBox.Text.Replace("\r", "").Split('\n'));
                    List<string> afList = new List<string>(afTextBox.Text.Replace("\r", "").Split('\n'));
                    List<string> itemList = new List<string>(itemTextBox.Text.Replace("\r", "").Split('\n'));
                    List<string> otherList = new List<string>(otherTextBox.Text.Replace("\r", "").Split('\n'));
                    List<string> weaponList = new List<string>(weaponTextBox.Text.Replace("\r", "").Split('\n'));
                    List<string> ammoList = new List<string>(ammoTextBox.Text.Replace("\r", "").Split('\n'));
                    List<string> brokenWeapons = new List<string>();

                    StreamReader treasureReader = new StreamReader($"{originalConfPath}/misc/treasure_manager.ltx");
                    List<string> treasureStringList = new List<string>(treasureReader.ReadToEnd().Split('\n'));

                    for (int i = 0; i < weaponList.Count; i++)
                    {
                        if (!weaponList[i].Contains(" "))
                        {
                            brokenWeapons.Add(weaponList[i]);
                            continue;
                        }

                        weaponList[i] = weaponList[i].Substring(0, weaponList[i].IndexOf(' '));
                    }

                    if (brokenWeapons.Count > 0)
                    {
                        string brokenWeaponString = "";
                        foreach (string weapon in brokenWeapons)
                        {
                            brokenWeaponString += weapon + " ||| ";
                        }
                        (new ErrForm($"Некоторые оружия не были добавлены в тайники " +
                            $"из-за неправильного форматирования. " +
                            $"Рекомендуется проверить форматирование всего списка оружия. " +
                            $"Обнаруженные проблемы:\n{brokenWeaponString}")).ShowDialog();
                    }

                    for (int j = 0; j < treasureStringList.Count; j++)
                    {
                        if (treasureStringList[j].Contains("items"))
                        {
                            string newItems = "";
                            int itemCount = rnd.Next(1, 7);

                            for (int i = 0; i < itemCount; i++)
                            {
                                int whichItemType = rnd.Next(100);

                                if (whichItemType < 10)
                                {
                                    newItems += generateItem(outfitList, 1);
                                }
                                else if (whichItemType < 25)
                                {
                                    newItems += generateItem(weaponList, 1);
                                }
                                else if (whichItemType < 35)
                                {
                                    newItems += generateItem(afList, 3);
                                }
                                else if (whichItemType < 65)
                                {
                                    newItems += generateItem(itemList, 8);
                                }
                                else if (whichItemType < 90)
                                {
                                    newItems += generateItem(ammoList, 6);
                                }
                                else
                                {
                                    newItems += generateItem(otherList, 2);
                                }

                                if (i < itemCount - 1)
                                {
                                    newItems += ", ";
                                }
                            }

                            treasureStringList[j] = "items = " + newItems + '\n';
                        }
                    }

                    string treasureString = "";

                    for (int i = 0; i < treasureStringList.Count; i++)
                    {
                        treasureString += treasureStringList[i];
                    }

                    Directory.CreateDirectory($"{confDir}/misc");
                    FileStream outputFile = new FileStream($"{confDir}/misc/treasure_manager.ltx", FileMode.Create);

                    byte[] buffer = Encoding.Default.GetBytes(treasureString);
                    outputFile.Write(buffer, 0, buffer.Length);
                }
            }
            catch
            {
                (new ErrForm("Ошибка генерации тайников. Операция прервана.")).ShowDialog();
                return;
            }
            //артефакты
            try
            {
                if (afCheckBox.Checked)
                {
                    StreamReader artReader = new StreamReader($"{originalConfPath}/misc/artefacts.ltx");
                    List<string> artefactsStringList = new List<string>(artReader.ReadToEnd().Replace("af_base", "\a").Split('\a'));

                    string artString = "";

                    for (int i = 2; i < artefactsStringList.Count; i++)
                    {
                        int statsNum = rnd.Next(1, 7);
                        List<Tuple<string, double>> afStats = generateAfStats(statsNum);

                        artefactsStringList[i] = replaceStat(artefactsStringList[i], "cost", rnd.Next(1000, 3001) * multiplier(30, 3));
                        artefactsStringList[i] = replaceStat(artefactsStringList[i], "inv_weight", (rnd.NextDouble() + 0.3) * multiplier(20, 3));

                        //Замена статов на пустые для последующего добавления новых
                        foreach (string stat in fullAfStats)
                        {
                            artefactsStringList[i] = replaceStat(artefactsStringList[i], stat, 1.0);
                        }
                        foreach (string stat in fullAfStats2)
                        {
                            artefactsStringList[i] = replaceStat(artefactsStringList[i], stat, 0.0);
                        }

                        foreach (Tuple<string, double> stat in afStats)
                        {
                            artefactsStringList[i] = replaceStat(artefactsStringList[i], stat.Item1, stat.Item2);
                        }
                    }

                    foreach (string it in artefactsStringList)
                    {
                        artString += it + "af_base";
                    }

                    Directory.CreateDirectory($"{confDir}/misc");
                    FileStream outputFile = new FileStream($"{confDir}/misc/artefacts.ltx", FileMode.Create);
                    byte[] buffer = Encoding.Default.GetBytes(artString);
                    outputFile.Write(buffer, 0, buffer.Length);
                }
            }
            catch
            {
                (new ErrForm("ошибка генерации характеристик артефактов. Операция прервана.")).ShowDialog();
                return;
            }
            //оружие
            try
            {
                if (weaponCheckBox.Checked)
                {
                    string[] weapons = Directory.GetFiles("./rndata/default/gamedata/config/weapons");
                    Directory.CreateDirectory($"{confDir}/weapons");

                    foreach (string it in weapons)
                    {
                        StreamReader weaponReader = new StreamReader(it);
                        string currWeapon = weaponReader.ReadToEnd();
                        int magSize = rnd.Next(1, 26) * multiplier(30, 2);

                        currWeapon =
                            replaceStat(currWeapon, "cost", rnd.Next(100, 3000) * multiplier(15, 10));
                        currWeapon =
                            replaceStat(currWeapon, "ammo_limit", magSize);
                        currWeapon =
                            replaceStat(currWeapon, "ammo_elapsed", magSize);
                        currWeapon =
                            replaceStat(currWeapon, "ammo_mag_size", magSize);
                        currWeapon =
                            replaceStat(currWeapon, "inv_weight", Math.Round(rnd.NextDouble() * 5 * multiplier(30, 2) + 0.2, 2));
                        currWeapon =
                            replaceStat(currWeapon, "fire_dispersion_base", Math.Round(rnd.NextDouble() * 0.75 * multiplier(50, 2) + 0.01, 2));
                        currWeapon =
                            replaceStat(currWeapon, "misfire_probability", Math.Round(rnd.NextDouble() * 0.01 + 0.001, 3));
                        currWeapon =
                            replaceStat(currWeapon, "condition_shot_dec", Math.Round(rnd.NextDouble() * 0.001 + 0.0001, 4));
                        currWeapon =
                            replaceStat(currWeapon, "hit_power", Math.Round(rnd.NextDouble() * multiplier(5, 30) + 0.01, 2));
                        currWeapon =
                            replaceStat(currWeapon, "hit_impulse", rnd.Next(50, 401));
                        currWeapon =
                            replaceStat(currWeapon, "fire_distance", rnd.Next(1, 1001));
                        currWeapon =
                            replaceStat(currWeapon, "bullet_speed", rnd.Next(10, 1001) * multiplier(20, 3));
                        currWeapon =
                            replaceStat(currWeapon, "rpm", rnd.Next(1, 1001));
                        currWeapon =
                            replaceStat(currWeapon, "silencer_hit_power", Math.Round(rnd.NextDouble() * multiplier(5, 30) + 0.01, 2));
                        currWeapon =
                            replaceStat(currWeapon, "silencer_hit_impulse", rnd.Next(50, 401));
                        currWeapon =
                            replaceStat(currWeapon, "silencer_fire_distance", rnd.Next(1, 1001));
                        currWeapon =
                            replaceStat(currWeapon, "silencer_bullet_speed", rnd.Next(1, 1001) * multiplier(20, 3));

                        byte[] buffer = Encoding.Default.GetBytes(currWeapon);

                        using (FileStream outputFile = new FileStream(it.Replace("./rndata/default/gamedata/config", confDir), FileMode.Create))
                        {
                            outputFile.Write(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
            catch
            {
                (new ErrForm("Ошбка генерации характеристик оружия. Операция прервана.")).ShowDialog();
                return;
            }
            //бронь
            try
            {
                if (armorCheckBox.Checked)
                {
                    Directory.CreateDirectory($"{confDir}/misc");
                    StreamReader outfitReader = new StreamReader("./rndata/default/gamedata/config/misc/outfit.ltx");
                    List<string> outfitFullList = new List<string>(outfitReader.ReadToEnd().Replace("outfit_base", "\a").Split('\a'));
                    string outfitStr = "";

                    for (int i = 3; i < outfitFullList.Count; i++)
                    {
                        int plusMaxWeight = rnd.Next(-15, 31);

                        outfitFullList[i] = replaceStat(outfitFullList[i], "inv_weight", rnd.Next(1, 11) * multiplier(20, 2));
                        outfitFullList[i] = replaceStat(outfitFullList[i], "cost", rnd.Next(500, 5000) * multiplier(15, 10));

                        foreach (string stat in fullOutfitStats)
                        {
                            outfitFullList[i] = replaceStat(outfitFullList[i], stat, Math.Round((rnd.NextDouble() * 1.5 - 0.6) / multiplier(80, 2), 2));
                        }

                        foreach (string immun in fullOutfitImmunities)
                        {
                            outfitFullList[i] = replaceStat(outfitFullList[i], immun, Math.Round(rnd.NextDouble() / 20, 3));

                        }

                        if (outfitFullList[i].Contains("additional_inventory_weight"))
                        {
                            outfitFullList[i] = replaceStat(outfitFullList[i], "additional_inventory_weight", plusMaxWeight);
                        }
                        else
                        {
                            outfitFullList[i] = outfitFullList[i].Insert(outfitFullList[i].IndexOf("[sect"), $"additional_inventory_weight = {plusMaxWeight}\n");
                        }

                        if (outfitFullList[i].Contains("additional_inventory_weight2"))
                        {
                            outfitFullList[i] = replaceStat(outfitFullList[i], "additional_inventory_weight2", plusMaxWeight + 10);
                        }
                        else
                        {
                            outfitFullList[i] = outfitFullList[i].Insert(outfitFullList[i].IndexOf("[sect"), $"additional_inventory_weight2 = {plusMaxWeight + 10}\n");
                        }
                    }

                    foreach (string it in outfitFullList)
                    {
                        outfitStr += it + "outfit_base";
                    }

                    byte[] buffer = Encoding.Default.GetBytes(outfitStr);

                    using (FileStream outputFile = new FileStream($"{confDir}/misc/outfit.ltx", FileMode.Create))
                    {
                        outputFile.Write(buffer, 0, buffer.Length);
                    }
                }
            }
            catch
            {
                (new ErrForm("Ошибка генерации характеристик брони. Операция прервана.")).ShowDialog();
                return;
            }
            //нпс
            try
            {
                if (npcCheckBox.Checked)
                {
                    List<string> exceptionList = new List<string>(npcExecptTextBox.Text.Replace("\r", "").Split('\n'));
                    List<string> weapAmmoList = new List<string>(weaponTextBox.Text.Replace("\r", "").Split('\n'));
                    Directory.CreateDirectory($"{confDir}/gameplay");

                    foreach (string it in Directory.GetFiles($"./rndata/default/gamedata/config/gameplay"))
                    {
                        StreamReader sr = new StreamReader(it);
                        List<string> npcDescList = new List<string>(sr.ReadToEnd().Replace("<specific_character", "\a").Split('\a'));

                        for (int i = 1; i < npcDescList.Count; i++)
                        {
                            bool isException = false;

                            foreach (string except in exceptionList)
                            {
                                if (npcDescList[i].Contains(except))
                                {
                                    isException = true;
                                    break;
                                }
                            }

                            if (isException)
                            {
                                continue;
                            }

                            if (npcDescList[i].Contains("<community>") && communityCheckBox.Checked)
                            {
                                List<string> communityList = new List<string>(communityTextBox.Text.Replace("\r", "").Split('\n'));
                                string community = communityList[rnd.Next(communityList.Count)];
                                string tmp = npcDescList[i].Substring(npcDescList[i].IndexOf("<community>"));

                                npcDescList[i] = npcDescList[i].Replace(tmp.Substring(0, tmp.IndexOf("</comm") + 12), $"<community>{community}</community>");
                            }

                            if (npcDescList[i].Contains("<visual>"))
                            {
                                string[] models = modelTextBox.Text.Replace("\r", "").Split('\n');
                                string model = models[rnd.Next(models.Length)];
                                string tmp = npcDescList[i].Substring(npcDescList[i].IndexOf("<visual>"));
                                npcDescList[i] = npcDescList[i].Replace(tmp.Substring(0, tmp.IndexOf('\n')), $"<visual>{model}</visual>");
                            }

                            if (npcDescList[i].Contains("<snd_config>"))
                            {
                                string[] sounds = soundTextBox.Text.Replace("\r", "").Split('\n');
                                string sound = sounds[rnd.Next(sounds.Length)];
                                string tmp = npcDescList[i].Substring(npcDescList[i].IndexOf("<snd_config>"));
                                npcDescList[i] = npcDescList[i].Replace(tmp.Substring(0, tmp.IndexOf('\n')), $"<snd_config>{sound}</snd_config>");
                            }

                            if (npcDescList[i].Contains("[spawn]"))
                            {
                                string supplies = npcDescList[i].Substring(npcDescList[i].IndexOf("[spawn]"), npcDescList[i].IndexOf("</supplies>") - npcDescList[i].IndexOf("[spawn]"));// [npcDescList[i].IndexOf("[spawn]")..npcDescList[i].IndexOf("</supplies>")];
                                List<string> suppList = new List<string>(supplies.Split('\n'));

                                for (int j = 0; j < suppList.Count; j++)
                                {
                                    if (suppList[j].Contains("wpn_") || suppList[j].Contains("ammo_"))
                                    {
                                        suppList.RemoveAt(j--);
                                    }
                                }

                                int weapNum = rnd.Next(weapAmmoList.Count);

                                string[] currWeapAmmo = weapAmmoList[weapNum].Split(' ');
                                string weapon = currWeapAmmo[0];
                                string ammo = currWeapAmmo[rnd.Next(currWeapAmmo.Length - 1) + 1];

                                suppList.Insert(1, weapon + " \\n\n");
                                suppList.Insert(1, ammo.Replace("\n", "").Replace("\r", "") + " \\n\n");

                                string newSupplies = "";
                                foreach (string supp in suppList)
                                {
                                    newSupplies += supp;
                                }

                                npcDescList[i] = npcDescList[i].Replace(supplies, newSupplies);
                            }
                        }

                        string outStr = "";

                        for (int i = 0; i < npcDescList.Count - 1; i++)
                        {
                            outStr += npcDescList[i] + "<specific_character";
                        }
                        outStr += npcDescList[npcDescList.Count - 1];

                        FileStream outputFile = new FileStream($"{it.Replace("./rndata/default/gamedata/config", confDir)}", FileMode.Create);
                        byte[] buffer = Encoding.Default.GetBytes(outStr);
                        outputFile.Write(buffer, 0, buffer.Length);

                    }
                }
            }
            catch
            {
                (new ErrForm("Ошибка генераци НПС. Операция прервана.")).ShowDialog();
                return;
            }

            //доп функции
            string message = "";
            try
            {
                string defaultGamedataPath = "./rndata/default/gamedata";

                if (communityCheckBox.Checked)
                {
                    message = communityCheckBox.Text;
                    File.Copy($"{defaultGamedataPath}/scripts/smart_terrain.script", $"{newGamedataPath}/scripts/smart_terrain.script");
                    File.Copy($"{defaultGamedataPath}/scripts/xr_gulag.script", $"{newGamedataPath}/scripts/xr_gulag.script");
                }

                if (equipWeaponEverywhereCheckBox.Checked)
                {
                    message = equipWeaponEverywhereCheckBox.Text;
                    File.Copy($"{defaultGamedataPath}/scripts/sr_no_weapon.script", $"{newGamedataPath}/scripts/sr_no_weapon.script");
                }

                if (barAlarmCheckBox.Checked)
                {
                    message = barAlarmCheckBox.Text;
                    File.Copy($"{defaultGamedataPath}/config/scripts/bar_territory_zone.ltx", $"{newGamedataPath}/config/scripts/bar_territory_zone.ltx");
                }

                if (giveKnifeCheckBox.Checked)
                {
                    message = giveKnifeCheckBox.Text;
                    File.Copy($"{defaultGamedataPath}/spawns/all.spawn", $"{newGamedataPath}/spawns/all.spawn");
                }

                if (disableFreedomAngryCheckBox.Checked)
                {
                    message = disableFreedomAngryCheckBox.Text;
                    File.Copy($"{defaultGamedataPath}/scripts/gulag_military.script", $"{newGamedataPath}/scripts/gulag_military.script");
                }

                if (respawnCheckBox.Checked)
                {
                    message = respawnCheckBox.Text;
                    File.Copy($"{defaultGamedataPath}/scripts/se_respawn.script", $"{newGamedataPath}/scripts/se_respawn.script");
                }

                if (translateCheckBox.Checked)
                {
                    string oldPath = $"{defaultGamedataPath}/config/text/rus";
                    string newPath = $"{newGamedataPath}/config/text/rus";
                    message = translateCheckBox.Text;
                    Directory.CreateDirectory($"{newGamedataPath}/config/text/rus");

                    foreach (string file in Directory.GetFiles(oldPath))
                    {
                        string tmpFile = file.Replace('\\', '/');
                        File.Copy(tmpFile, newPath + tmpFile.Substring(tmpFile.LastIndexOf('/')));
                    }
                }
            }
            catch
            {
                (new ErrForm("Ошибка при копировании дополнителных настроек. Операция прервана." + $"\n({message})")).ShowDialog();
                return;
            }

            (new  ErrForm("Сохранено")).ShowDialog();
        }

        //загрузка списков по умолчанию
        private void loadDefaultButton_Click(object sender, EventArgs e)
        {
            loadLists(true);
        }

        //заполнения текстовых полей
        //type, а не fileName, потому что при загрузке дефолтных списокв
        //добавляется слово default/
        private void fillTextBox(string type, TextBox textBox)
        {
            try
            {
                using (StreamReader sr = new StreamReader($"./rndata/{type}.txt"))
                {
                    textBox.Text = sr.ReadToEnd();
                }
            }
            catch
            {
                errList.Add(type);
            }
        }

        //загрузка списков редактируемых или дефолтных
        private void loadLists(bool isDefault)
        {
            errList.Clear();

            if (isDefault)
            {
                //дефолтным не нужно перезаполнять список loadedDataList
                //чтоб оставались отличия от кеша для проверки на необходимость сохранения
                fillTextBox("default/community", communityTextBox);
                fillTextBox("default/other", otherTextBox);
                fillTextBox("default/af", afTextBox);
                fillTextBox("default/ammo", ammoTextBox);
                fillTextBox("default/item", itemTextBox);
                fillTextBox("default/model", modelTextBox);
                fillTextBox("default/outfit", armorTextBox);
                fillTextBox("default/sound", soundTextBox);
                fillTextBox("default/weapon", weaponTextBox);
                fillTextBox("default/npcexception", npcExecptTextBox);
            }
            else
            {
                loadedDataList.Clear();

                fillTextBox("community", communityTextBox);
                fillTextBox("other", otherTextBox);
                fillTextBox("af", afTextBox);
                fillTextBox("ammo", ammoTextBox);
                fillTextBox("item", itemTextBox);
                fillTextBox("model", modelTextBox);
                fillTextBox("outfit", armorTextBox);
                fillTextBox("sound", soundTextBox);
                fillTextBox("weapon", weaponTextBox);
                fillTextBox("npcexception", npcExecptTextBox);

                foreach (TextBox tb in textBoxList)
                {
                    loadedDataList.Add(tb.Text);
                }
            }

            if (errList.Count > 0)
            {
                string errMessage = "Не удалось загрузить следующие файлы:\n\n";

                foreach (string file in errList)
                {
                    errMessage += file + ".txt, ";
                }

                ErrForm errForm = new ErrForm(errMessage);
                errForm.ShowDialog();
            }
        }

        //загрузка списков при старте приложения
        private void Form1_Shown(object sender, EventArgs e)
        {
            loadLists(false);
        }

        private void allCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool allState = allCheckBox.Checked;

            foreach (CheckBox cb in generateTypeCheckBoxList)
            {
                cb.Checked = allState;
            }
        }

        //Предмет и количество для добавления в тайник
        private string generateItem(List<string> itemList, int maxItemCount)
        {
            int itemPackCount = 1;
            string item = itemList[rnd.Next(0, itemList.Count - 1)];

            if (item.Contains(" "))
            {
                try
                {
                    itemPackCount = Convert.ToInt32(item.Split(' ')[1]);
                }
                catch
                {
                }
                item = item.Split(' ')[0];
            }

            int count = rnd.Next(1, maxItemCount + 1) * itemPackCount;

            return item + ", " + count;
        }

        //замена целочисленного стата файла
        string replaceStat(string item, string statName, int statValue)
        {
            if (item.Contains(statName))
            {
                string tmp = item.Substring(item.IndexOf(statName));
                return item.Replace(tmp.Substring(0, tmp.IndexOf('\n')), statName + " = " + statValue);
            }

            return item;
        }

        //замена дробного стата файла
        string replaceStat(string item, string statName, double statValue)
        {
            if (item.Contains(statName))
            {
                string tmp = item.Substring(item.IndexOf(statName));
                return item.Replace(tmp.Substring(0, tmp.IndexOf('\n')), statName + " = " + statValue);
            }

            return item;
        }

        //генерация статов артов
        List<Tuple<string, double>> generateAfStats(int statsNum)
        {
            List<string> statsList = new List<string>(fullAfStats);
            statsList.AddRange(fullAfStats2);
            List<Tuple<string, double>> tmpString = new List<Tuple<string, double>>();

            for (int i = 0; i < statsNum; i++)
            {
                double rndStat = 0.0;
                int rndInd = rnd.Next(0, statsList.Count);
                string currStat = statsList[rndInd];
                statsList.RemoveAt(rndInd);

                if (currStat == "radiation_restore_speed")
                {
                    rndStat = Math.Round((rnd.NextDouble() * 0.01 - 0.005) / multiplier(80, 2), 4);
                }
                else if (currStat == "health_restore_speed")
                {
                    rndStat = Math.Round((rnd.NextDouble() * 0.002 - 0.001) / multiplier(80, 2), 4);
                }
                else if (currStat == "power_restore_speed")
                {
                    rndStat = Math.Round((rnd.NextDouble() * 0.02 - 0.01) / multiplier(80, 2), 3);
                }
                else if (currStat == "bleeding_restore_speed")
                {
                    rndStat = Math.Round((rnd.NextDouble() * 0.04 - 0.02) / multiplier(80, 2), 3);
                }
                else
                {
                    rndStat = Math.Round(((rnd.NextDouble() * 0.8 - 0.4) / multiplier(70, 2)) + 1.0, 2);
                }

                tmpString.Add(new Tuple<string, double>(currStat, rndStat));
            }

            return tmpString;
        }

        //дополнительный множитель
        int multiplier(int probability, int multValue)
        {
            if (rnd.Next(100) < probability)
            {
                return multValue;
            }

            return 1;
        }

        //надпись "рекомендуется" при активации рандома группировок
        private void communityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Label label in recommendLabelList)
            {
                label.Visible = communityCheckBox.Checked;
            }
        }

        private void weaponGuideButton_Click(object sender, EventArgs e)
        {
            new GuideForm(0).ShowDialog();
        }

        private void itemGuideButton_Click(object sender, EventArgs e)
        {
            new GuideForm(1).ShowDialog();
        }

        private void npcGuideButton_Click(object sender, EventArgs e)
        {
            new GuideForm(2).ShowDialog();
        }
    }
}
