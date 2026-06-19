
-- in this file i will be designing the database table for the cafeteria menu project
-- this table will store daily cafeteria menus
-- each row will represent one daily menu

CREATE TABLE MenuItems
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    MenuDate DATE NOT NULL,
    Soup NVARCHAR(100),
    MainCourse NVARCHAR(100) NOT NULL,
    SideDish NVARCHAR(100),
    ExtraItem NVARCHAR(100)
);

INSERT INTO MenuItems
(
    MenuDate, Soup, MainCourse, SideDish, ExtraItem
)
VALUES
(
    '2026-06-19',
    'Ezogelin Çorbası',
    'Tavuk Dürüm',
    'Yeşil Salata',
    'Ayran'
);

INSERT INTO MenuItems
(
    MenuDate, Soup, MainCourse, SideDish, ExtraItem
)
VALUES
(
    '2026-06-22',
    'Domates Çorbası',
    'Mantı',
    'Maş Fasulyesi Salatası',
    NULL
);

INSERT INTO MenuItems
(
    MenuDate, Soup, MainCourse, SideDish, ExtraItem
)
VALUES
(
    '2026-06-23',
    'Mısır Çorbası',
    'Fellah Köftesi',
    'Peynirli Börek ve Havuç Tarator',
    NULL
);

INSERT INTO MenuItems
(
    MenuDate, Soup, MainCourse, SideDish, ExtraItem
)
VALUES
(
    '2026-06-24',
    'Mercimek Çorbası',
    ' Hasan Paşa Köfte',
    'Karışık Salata',
    NULL
);

INSERT INTO MenuItems
(
    MenuDate, Soup, MainCourse, SideDish, ExtraItem
)
VALUES
(
    '2026-06-25',
    'Sebze Çorbası',
    'Lahana Sarması',
    'Meksika Fasulyesi Salatası',
    'Yoğurt'
);

INSERT INTO MenuItems
(
    MenuDate, Soup, MainCourse, SideDish, ExtraItem
)
VALUES
(
    '2026-06-26',
    'Yayla Çorbası',
    'Hindi Külbastı',
    'Patates Püresi',
    'Salata'
);

INSERT INTO MenuItems
(
    MenuDate, Soup, MainCourse, SideDish, ExtraItem
)
VALUES
(
    '2026-06-29',
    'Mercimek Çorbası',
    'Etsiz Nohut',
    'Pirinç Pilavı',
    'Turşu'
);

INSERT INTO MenuItems
(
    MenuDate, Soup, MainCourse, SideDish, ExtraItem
)
VALUES
(
    '2026-06-30',
    'Köz Biber Çorbası',
    'Lazanya',
    'Havuç Tarator',
    NULL
);

INSERT INTO MenuItems
(
    MenuDate, Soup, MainCourse, SideDish, ExtraItem
)
VALUES
(
    '2026-07-01',
    'Yoğurt Çorbası',
    'Taze Fasulye',
    'Şehriye Salatası',
    'Karpuz'
);

INSERT INTO MenuItems
(
    MenuDate, Soup, MainCourse, SideDish, ExtraItem
)
VALUES
(
    '2026-07-02',
    'Ezogelin Çorbası',
    'Köri Soslu Tavuk',
    'Tereyağlı Makarna',
    'Salata'
);

INSERT INTO MenuItems
(
    MenuDate, Soup, MainCourse, SideDish, ExtraItem
)
VALUES
(
    '2026-07-03',
    'Köz Biber Çorbası',
    'Patlıcanlı Patates Kıymalı Oturtma',
    'Yoğurt',
    NULL
);


SELECT * 
FROM MenuItems;

SELECT *
FROM MenuItems
WHERE MenuDate = '2026-06-19';

SELECT *
FROM MenuItems
ORDER BY MenuDate;

SELECT *
FROM MenuItems
ORDER BY MenuDate DESC;