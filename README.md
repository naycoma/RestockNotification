# Restock Notification (Continued)

[![Original](https://img.shields.io/badge/Workshop-3241844246-blue?logo=steam)](https://steamcommunity.com/sharedfiles/filedetails/?id=3241844246)
[![RimWorld 1.5](https://img.shields.io/badge/RimWorld-1.5-brightgreen)](https://rimworldgame.com/)
[![RimWorld 1.6](https://img.shields.io/badge/RimWorld-1.6-brightgreen)](https://rimworldgame.com/)

Send a letter when settlement which ever visited regenerate stock.

これまでに訪れたことのある拠点の物品が再入荷されたときにアラートを通知します。

> This is an updated version of an existing mod, and I don't claim ownership of it. I'll remove it if the original author requests.
>
> Original:
> [Restock Notification[1.1-1.4]](https://steamcommunity.com/sharedfiles/filedetails/?id=2079149222)

## Language

- English
- Japanese
- Chinese Simplified (by Zephyr)
- Chinese Traditional (by Zephyr)
- French (by Blake)

## Build

ビルド後は自動的に `{LocalModsPath}/RestockNotification/` にステージされます。

以下のいずれかの方法でパスを指定してください。

### 自動検出 (Windows / PowerShell)

インストール先を自動検出

```powershell
./build-autodetect.ps1
```

### パスを直接指定

```sh
dotnet build mod.csproj `
  -p:RimWorldPath="C:/Program Files (x86)/Steam/steamapps/common/RimWorld" `
  -p:WorkshopPath="C:/Program Files (x86)/Steam/steamapps/workshop/content/294100" `
  -p:LocalModsPath="C:/Program Files (x86)/Steam/steamapps/common/RimWorld/Mods"
```

### mod.props で上書き

`mod.props` を置いてデフォルトパスを変更

```xml
<Project>
  <PropertyGroup>
    <RimWorldPath>C:/Program Files (x86)/Steam/steamapps/common/RimWorld</RimWorldPath>
    <WorkshopPath>C:/Program Files (x86)/Steam/steamapps/workshop/content/294100</WorkshopPath>
    <LocalModsPath>C:/Program Files (x86)/Steam/steamapps/common/RimWorld/Mods</LocalModsPath>
  </PropertyGroup>
</Project>
```

```sh
dotnet build mod.csproj
```

## License

- [CC BY-NC-SA](https://creativecommons.org/licenses/by-nc-sa/4.0/)
- [MIT License — Copyright 2020 TammyBee](LICENSE)
