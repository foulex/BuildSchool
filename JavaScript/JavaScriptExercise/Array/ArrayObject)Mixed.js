//district 區
let districtObject ={
    taipei:     [
        { id:'taipei01', district:'中正區' },
        { id:'taipei02', district:'萬華區' },
        { id:'taipei03', district:'信義區' },
    ],
    taoyuan:    [
        { id:'taoyuan01', district:'桃園市' },
        { id:'taoyuan02', district:'八德市' },
        { id:'taoyuan03', district:'中壢市' },
    ],
    taichung:   [
        { id:'taichung01', district:'台中市' },
        { id:'taichung02', district:'大里市' },
        { id:'taichung03', district:'清水市' },
    ]
};

let cities = Object.keys(districtObject);
let values = Object.values(districtObject);

cities.forEach(function (city) {
    let districtsArray = districtObject[city];
    districtsArray.forEach(function(dt){
        console.log(`City:${city}, ID: ${dt.id}, DS: ${dt.district}`);
    })
})

let districtsArray = [
    {city:'台北', id: 'taipei01', district:'中正區'},
    {city:'台北', id: 'taipei02', district:'萬華區'},
    {city:'台北', id: 'taipei03', district:'信義區'},
    {city:'桃園', id: 'taoyuan01', district:'桃園市'},
    {city:'桃園', id: 'taoyuan02', district:'八德市'},
    {city:'桃園', id: 'taoyuan03', district:'中壢市'},
    {city:'台中', id: 'taichung01', district:'台中市'},
    {city:'台中', id: 'taichung02', district:'大里市'},
    {city:'台中', id: 'taichung03', district:'清水市'},
]

