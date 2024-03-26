# Comparing Native vs Drawn

Performance comparison between a [CollectionView](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/collectionview) and [DrawnUI](https://github.com/taublast/AppoMobi.Maui.DrawnUi.Demo) for .NET MAUI.

## Implementation

Converted a copy of XAML views of an original [Surfing App](https://github.com/jsuarezruiz/netmaui-surfing-app-challenge) to be drawn on a skia canvas.  

https://github.com/taublast/SurfAppCompareDrawn/assets/25801194/3fa08b5c-746a-4720-b2ac-b5f0c5af4799

## To Note

Cells are recycled. CollectionView runs with shadows off.

## _What's New_

* NET 8
* New SkiaSharp3 preview nuget enabled hardware-acceleration for Windows, MacCatalyst and [other features and fixes](https://github.com/taublast/DrawnUi.Maui). 

## Copyright and license

Code released under the [MIT license](https://opensource.org/licenses/MIT).
