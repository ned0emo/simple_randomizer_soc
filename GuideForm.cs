﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreasuresSoC
{
    public partial class GuideForm : Form
    {
        private string weaponGuide = "Список оружия и используемых патронов:\n" +
            "Используется для добавления в тайники оружия и выдаче оружия НПС. Тип патронов необходим для " +
            "добавления к НПС, чтоб челы имели боеприпас для перезарядки.\n" +
            "Разделять патроны и оружие необходимо одиночным пробелом. Разделять оружие между собой \"ентером\". " +
            "В конце списка не должно быть пустых строк\n\n" +
            "Список патронов и количества в одной пачке:\n" +
            "Используется для добавления патронов в тайники. Количество патронов в пачке необходимо для " +
            "устранения дисбаланса между генераций разных типов патронов. Так, если генерировать чисто в " +
            "диапазоне от 1 до 100, можно получить 80 ракет от РПГ и 3 патрона 9х18. Указание количества в пачке " +
            "исправляет эту проблему.\nРазделять патроны с количеством необходимо одиночным пробелом. " +
            "Разделать патроны между собой - \"ентером\". В конце списка не должно быть пустых строк\n\n" +
            "Данные списки не используются для генерации статов оружия. Статы оружия считываются и изменяются " +
            "в своих *.ltx файлах в директории ./rndata/default/gamedata/config/weapons";
        private string itemsGuide = "Все списки на данной вкладке используются только для добавления предметов " +
            "в тайники.\n\nГенерация статов брони и артефактов происходит в файлах outfit.ltx и artefacts.ltx " +
            "соответственно (директория ./rndata/default/gamedata/config/misc) и не зависит от данных списков\n\n" +
            "В конце списков не должно быть пустых строк. В строках не должно быть пробелов и прочих лишних символов.";
        private string npcGuide = "Список моделей:\n" +
            "Используется для выдачи случайной модели НПС. Пути к моделям прописываются из папки gamedata/meshes.\n" +
            "Сами модели читать и редактировать не надо, потому для изменения доступных моделей НПС достаточно " +
            "изменить список без копирования самих файлов моделей куда-либо\n\n" +
            "Список озвучки:\n" +
            "Используется для выдачи случайной озвучки НПС. Пути к озвучке прописываются из папки gamedata/sounds.\n" +
            "Аналогично моделям сами файлы озвучки не нужны для работы программы, достаточно просто отредактировать список, " +
            "если применяете программу с модом с дополнительной озвучкой. В отличие от путей к моделям " +
            "здесь нужно добавлять в конец строк обратный слэш.\n\n" +
            "Список группировок:\n" +
            "Названия группировок можно взять с файла game_relations.ltx (не используется в данной программе) " +
            "или с файлов character_desc_*.xml. Тут все понятно\n\n" +
            "Список исключений:\n" +
            "Не у всех НПС можно изменять свойства. Для таких случаев и создан этот список. В оригинале, к примеру, " +
            "трогать нельзя Бармена и Сидоровича. Меченого редачить можно, " +
            "но там поменяться может только группировка, что не очень удобно, " +
            "потому он тоже в исключенях по умолчанию\nДля добавления НПС в исключения " +
            "можно использовать параметр id тега specific_character " +
            "в файлах character_desc_*.xml, расположенных в ./rndata/gamedata/config/gameplay.\n\n" +
            "Как и везде, разумеется, никаких пробелов лишних символов в строках. И никаких пустых строк в конце списков.";
        public GuideForm(int guideType)
        {
            InitializeComponent();

            switch (guideType)
            {
                case 0:
                    guideLabel.Text = weaponGuide;
                    break;
                case 1:
                    guideLabel.Text = itemsGuide;
                    break;
                case 2:
                    guideLabel.Text = npcGuide;
                    break;
            }
        }
    }
}