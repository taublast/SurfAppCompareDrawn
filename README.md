# Surfing App MAUI/Drawn

Performance comparison between [.NET MAUI CollectionView](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/collectionview) and its [DrawnUI](https://github.com/taublast/AppoMobi.Maui.DrawnUi.Demo) alternative.

## Implementation

Created a copy of Xaml views of an [original Surfing App](https://github.com/jsuarezruiz/netmaui-surfing-app-challenge) and converted them to be drawn on a skia canvas. 

https://github.com/taublast/SurfAppCompareDrawn/assets/25801194/3fa08b5c-746a-4720-b2ac-b5f0c5af4799

## To Note 

Both CollectionView and DrawnUI cells are recycled. MAUI CollectionView does not use shadows, DrawnUI does.

## Copyright and license

Code released under the [MIT license](https://opensource.org/licenses/MIT).
