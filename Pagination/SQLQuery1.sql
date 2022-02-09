create table UserInfo
(
ID int primary key,
Name nvarchar(50),
Address nvarchar(50)
);

INSERT INTO UserInfo (
    ID,
    Name,
    Address
)
VALUES
    (
        4,
        'Mohamma4',
        'Test@tes4'
    ),
    (
        5,
        'Mohammad5',
        'Test@test5'
    ),
    (
        6,
        'Mohammad6',
        'Test@test6'
    );