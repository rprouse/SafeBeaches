

var safeSource = new ol.source.Vector({});
var unsafeSource = new ol.source.Vector({});

//create a bunch of icons and add to source vector
for (var i = 0 ; i < safe.length; i++) {

  var iconFeature = new ol.Feature({
    geometry: new ol.geom.Point(ol.proj.transform([safe[i].lat, safe[i].lon], 'EPSG:4326', 'EPSG:3857')),
    name: safe[i].name
  });
  safeSource.addFeature(iconFeature);
}

for (var i = 0 ; i < unsafe.length; i++) {

  var iconFeature = new ol.Feature({
    geometry: new ol.geom.Point(ol.proj.transform([unsafe[i].lat, unsafe[i].lon], 'EPSG:4326', 'EPSG:3857')),
    name: unsafe[i].name
  });
  unsafeSource.addFeature(iconFeature);
}

//create the style
var safeStyle = new ol.style.Style({
  image: new ol.style.Icon(({
    anchor: [0.5, 0.5],
    anchorXUnits: 'fraction',
    anchorYUnits: 'fraction',
    opacity: 0.75,
    src: '/Content/swim.png'
  }))
});

var unsafeStyle = new ol.style.Style({
  image: new ol.style.Icon(({
    anchor: [0.5, 0.5],
    anchorXUnits: 'fraction',
    anchorYUnits: 'fraction',
    opacity: 0.75,
    src: '/Content/no_swim.png'
  }))
});

//add the feature vector to the layer vector, and apply a style to whole layer
var safeLayer = new ol.layer.Vector({
  source: safeSource,
  style: safeStyle
});
var unsafeLayer = new ol.layer.Vector({
  source: unsafeSource,
  style: unsafeStyle
});

var map = new ol.Map({
  target: 'map',
  layers: [
    new ol.layer.Tile({
      source: new ol.source.MapQuest({ layer: 'osm' })
    }),
    safeLayer,
    unsafeLayer
  ],
  view: new ol.View({
    center: ol.proj.transform([-79.90, 43.28], 'EPSG:4326', 'EPSG:3857'),
    zoom: 12
  })
});