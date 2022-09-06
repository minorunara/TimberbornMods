## Beavers Edition of Transport Tycoon

This mod adds a facility that will help you when you want to build up a transport empire for your beavers.

There are currently 3 facilities.

### 10x Distribution Post

a distribution post that grants 10x strength to workers. This means that a beaver can export 140 kg and a golem 200 kg at a time.

![10xDistribution](https://github.com/minorunara/TimberbornMods/blob/main/10xDistributionPost/attachments/10xDistribution.png?raw=true)

### Drop-off Market

It requires construction costs and is a bit large, but it is a drop-off point that can store 2,000 cargoes.

Furthermore, even if many beavers visit all at once, there is no queue to wait their turn. (In the base game, warehouses and drop-off points can become congested when many beavers visit all at once.) This will be especially useful for packaged food products that are prone to crowding.

![LargeDropOffPoint](https://github.com/minorunara/TimberbornMods/blob/main/10xDistributionPost/attachments/LargeDropOffPoint.png?raw=true)

### Small Distribution Post

Space-saving 2x2 distribution post. For import/export to/from smaller districts due to low transport capacity.

![SmallDistributionPost](https://github.com/minorunara/TimberbornMods/blob/main/10xDistributionPost/attachments/SmallDistributionPost.png?raw=true)

## Disclaimer!

This mod is currently only supported in version 0.2.5.3 of Timberborn. Other versions will probably not work (and may crash the game).

## Install

If you install manually, put the downloaded folder in the folder where Timberborn.exe is located \BepInEx\plugins\

Remember that you will also need to install any mods that are dependencies.

## How to use

You should find under the labor tab.

## Caution
- Workers at distribution posts will not export shipments less than 25% of the weight they can carry. (except when set by district distribution limits. e.g. if the upper limit of the destination district is 100 and the district has only 99 items, the worker will export only 1 item.)

- The drop-off point has a capacity of only 300 and cannot accept too many routes.

- If multiple routes are to be established for a single drop-off market, the district distribution limits should be carefully set. For example, if the district is set to accept more than 2000 (including ∞) loaves of bread, the market will be full of bread and will not accept other items.

- The 10x distribution post will buffer 200 units of items per route. You can revert by deleting a route. However, there must be room in the warehouse that is set up to accept the item.

- It is more efficient to have a warehouse to store items to be exported near the distribution center. When daisy-chaining multiple districts, it is a good idea to have drop-off points and distribution posts close together.

![DaisyChainExample](https://github.com/minorunara/TimberbornMods/blob/main/10xDistributionPost/attachments/DaisyChainExample.png?raw=true)

## Other general tips
- Keep distribution posts and destinations as close as possible. Distance greatly affects efficiency. If the destinations are very far apart, it makes sense to create a relay district in between.

- Beavers do not export when the travel distance is long and close to the end of the workday. To avoid this, use golems. Golems can also carry more than beaver.

- Remember to set district distribution limits correctly.


## License

This mod was made from Elec's ExtendedArchitecture, so the license follows the original mod.

https://github.com/Timberborn-Modding-Central/ExtendedArchitecture/tree/main/Assets/ExtendedArchitecture

## Changelog

### 1.2.0  Target game version is (v0.2.5.3)  - 2022/08/27

A Small Distribution Post has been added.

10x Distribution Posts now have lights.

### 1.1.1(hot fix)  Target game version is (v0.2.5.0)  - 2022/08/25

Timberborn version v0.2.5.0 is now supported.

Swimming buffs were removed from the base game and no longer function.

Because of the increased default strength, the amount that beavers and golems can carry has increased.

The buffer per route was accordingly increased to 200.

### 1.1.0  Target game version is (v0.2.4.1)  - 2022/08/23

Drop-off market added.

The floor texture of the 10x distribution post in Folktail has been changed to plank.

### 1.0.3  Target game version is (v0.2.3.1)  - 2022/08/06

Fixed a bug in version 0.2.3.1 of Timberborn that prevented construction from progressing.

Migrated to Unity version 2022.1.6f1.

The model was changed.

Shaders have been changed.

### 1.0.2 - 2022/08/01

The number of routes was increased from 6 to 10.

### 1.0.1 - 2022/07/23

Fixed a bug that caused roads to connect in only two directions.

Migrated Unity project to 2022.1.8f1.

Workers now rest on carts and boats when idle :D

### 1.0.0 Target game version is (v0.2.2.1) - 2022/07/22

Released