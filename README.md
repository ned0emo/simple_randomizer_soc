# simple_randomizer_soc
Небольшая программа, которая позволяет рандомно изменить некоторые геймплейные элементы S.T.A.L.K.E.R.: Shadow of Chernobyl

A small program for random changes of some gameplay elements of the S.T.A.L.K.E.R.: Shadow of Chernobyl.

# Некоторые инструкции
Исполняемый файл программы должен находиться в той же папке, что и папка rndata из архива 'rndata.zip'

Формат списка оружия:

[имя_оружия] [первый_тип_патронов] [второй_тип_патронов] [...] [n_тип_патронов]

[имя_оружия] [первый_тип_патронов] [второй_тип_патронов] [...] [n_тип_патронов]

...

Формат списка патронов:

[имя_патронов] [количество_патронов_в_одной_пачке]

[имя_патронов] [количество_патронов_в_одной_пачке]

...

Формат списка моделей НПС:

[путь_к_модели_НПС_в_папке_models_оригинальной_gamedata]

[путь_к_модели_НПС_в_папке_models_оригинальной_gamedata]

...


Формат списка озвучки:

[путь_к_озвучке_НПС_в_папке_sounds_оригинальной_gamedata]

[путь_к_озвучке_НПС_в_папке_sounds_оригинальной_gamedata]

...

# Почему опции на последней вкладке не работают с другими модами
В отличие от остальных вкладок, которые редактируют файлы независимо оттого, модифицированные они или оригинальные, настройки на вкладке "Дополнительно" копируют заранее отредактированные файлы, которые в случае копирования в другой мод могут перезаписать его файлы и этот самый мод поломать


# Some instructions
Output *.exe file must must be in the same directory as the folder 'rndata' that is in the archive 'rndata.zip'

Weapon list format:

[weapon_name] [first_ammo] [second_ammo] [...] [n_ammo]

[weapon_name] [first_ammo] [second_ammo] [...] [n_ammo]

...

Ammo list format:

[ammo_name] [number_of_ammos_in_one_pack]

[ammo_name] [number_of_ammos_in_one_pack]

...

NPC's models list format:

[path_to_npc_model_in_models_folder_of_original_gamedata_directory]

[path_to_npc_model_in_models_folder_of_original_gamedata_directory]

...


NPC's sounds list format:

[path_to_npc_sound_in_sounds_folder_of_original_gamedata_directory]

[path_to_npc_sound_in_sounds_folder_of_original_gamedata_directory]

...

# Why options on the Advanced tab incompatible with other mods?
Options on this tab just copy and paste modified files instead of generating new files based on ones, which you can replace by modificate files.
