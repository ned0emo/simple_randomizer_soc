using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasuresSoC
{
    internal class Language
    {
        public string currLang;
        public string programName;
        //названия вкладок
        public string weaponTabString;
        public string outfitTabString;
        public string afTabString;
        public string addonTabString;
        public string ammoTabString;
        public string itemsTabString;
        public string monsterTabString;
        public string npcTabString;
        public string extraTabString;
        //названия списков
        public string weaponListString;
        public string ammoListString;
        public string modelListString;
        public string soundListString;
        public string exceptionListString;
        public string communityListString;
        //доп параметры
        public string descriptionString;
        public string respawnString;
        public string translationString;
        public string communityString;
        public string weaponInBarString;
        public string alarmString;
        public string knifeString;
        public string freedomString;
        public string recommendString;
        //галочки
        public string allButtonString;
        public string treasureButtonString;
        public string afButtonString;
        public string weaponButtonString;
        public string outfitButtonString;
        public string npcButtonString;
        //кнопки
        public string generateButtonString;
        public string saveButtonString;
        public string loadButtonString;
        public string defaultButtonString;
        //ошибки
        public string gamedataError;
        public string treasureError;
        public string afError;
        public string weaponError;
        public string outfitError;
        public string npcError;
        public string extraError;
        public string saveNoError;

        public Language(string currLang)
        {
            this.currLang = currLang;

            if (currLang == "ENG")
            {
                programName = "Simple Randomizer for Shadow of Chernobyl";

                weaponTabString = "Weapons";
                outfitTabString = "Outfits";
                afTabString = "Artifacts";
                addonTabString = "Addons";
                ammoTabString = "Ammo";
                itemsTabString = "Items";
                monsterTabString = "Monster items";
                npcTabString = "NPC";
                extraTabString = "Advanced";

                weaponListString = "List of weapons and ammo used in it";
                ammoListString = "List of ammunition and the number of them in one pack";
                modelListString = "List of models";
                soundListString = "List of sounds";
                exceptionListString = "Exceptions";
                communityListString = "Communities";

                descriptionString =
                    "The program can theoretically be used with a lot of mods." +
                    " You should replace all files with modificated in directories \"gameplay\"," +//Для этого в папке ./rndata/default/gamedata/config" +
                    " \"misc\" and \"weapons\" that are located in \"./rndata/default/gamedata/config\" folder." +
                    " Then you can change the lists by adding items from the mod.\n\n" +
                    "The options on this tab will most likely not work with other mods.";
                respawnString = "Increase the frequency of NPC respawn";
                translationString = "Funny russian translation (It only works on the russian version of the game)";
                communityString = "Change NPC community";
                weaponInBarString = "The player does not remove the weapon in the bar or scientists' bunker";
                alarmString = "Disable alarm in the bar, when player kills someone";
                knifeString = "Give the player a knife at the beginning of the game";
                freedomString = "Disable the hostility of the Freedom base if there are NPCs hostile to the player on it";
                recommendString = "(Recommended)";

                allButtonString = "All";
                treasureButtonString = "Treasures";
                afButtonString = "Artifacts";
                weaponButtonString = "Weapons";
                outfitButtonString = "Outfits";
                npcButtonString = "NPC";

                generateButtonString = "Generate";
                saveButtonString = "Save lists";
                loadButtonString = "Load lists";
                defaultButtonString = "Load default lists";

                gamedataError = "Error creating the \"gamedata\" directory. Operation aborted";
                treasureError = "Error generating caches. Operation aborted";
                afError = "Error generating artifact characteristics. Operation aborted";
                weaponError = "Error generating weapon characteristics. Operation aborted";
                outfitError = "Error generating outfit characteristics. Operation aborted";
                npcError = "Error generating NPC. Operation aborted";
                extraError = "Error when copying additional settings. Operation aborted";
                saveNoError = "Saved";
            }
            else
            {
                programName = "Простой рандомайзер для Тень Чернобыля";

                weaponTabString = "Оружие";
                outfitTabString = "Броня";
                afTabString = "Артефакты";
                addonTabString = "Обвесы";
                ammoTabString = "Патроны";
                itemsTabString = "Расходники";
                monsterTabString = "Части монстров";
                npcTabString = "НПС";
                extraTabString = "Дополнительно";

                weaponListString = "Список оружия и используемых в нем патронов";
                ammoListString = "Список патронов и количества их в одной пачке";
                modelListString = "Список моделей";
                soundListString = "Список озвучки";
                exceptionListString = "Исключения";
                communityListString = "Группировки";

                descriptionString = 
                    "Программа теоретически может быть использована с большинством модов." +
                    " Для этого нужно в папке ./rndata/default/gamedata/config" +
                    " в директориях gameplay, misc и weapons заменить все файлы на модифицированные." +
                    " После чего следует поправить списки.\n\n" +
                    "Однако параметры на данной вкладке с большой вероятностью" +
                    " не будут работать с другими модами.";
                respawnString = "Увеличить частоту респавна NPC";
                translationString = "Охлаждающий трахание перевод";
                communityString = "Изменять группировку НПС";
                weaponInBarString = "Возможность достать оружие в баре, в бункере ученых и у Сидоровича";
                alarmString = "Отключить тревогу в Баре, когда игрок кого-то убивает";
                knifeString = "Дать ГГ нож в начале игры";
                freedomString = "Отключить враждебность базы Свободы при наличии на ней НПС, враждебных к ГГ";
                recommendString = "(Рекомендуется)";

                allButtonString = "Все";
                treasureButtonString = "Тайники";
                afButtonString = "Артефакты";
                weaponButtonString = "Оружие";
                outfitButtonString = "Броня";
                npcButtonString = "НПС";

                generateButtonString = "Сгенерировать";
                saveButtonString = "Сохранить списки";
                loadButtonString = "Загрузить списки";
                defaultButtonString = "Списки по умолчанию";

                gamedataError = "Ошибка создания директории gamedata. Проверьте права доступа на запись. Операция прервана";
                treasureError = "Ошибка генерации тайников. Операция прервана";
                afError = "Ошибка генерации характеристик артефактов. Операция прервана";
                weaponError = "Ошибка генерации характеристик оружия. Операция прервана";
                outfitError = "Ошибка генерации характеристик брони. Операция прервана";
                npcError = "Ошибка генерации НПС. Операция прервана";
                extraError = "Ошибка при копировании дополнительных настроек. Операция прервана";
                saveNoError = "Сохранено";
            }
        }
    }
}
