CREATE DATABASE Learning;

GO

USE Learning;

GO

CREATE TABLE products(
    id INT PRIMARY KEY IDENTITY,
    name VARCHAR(45) NOT NULL,
    price NUMERIC(8,2) NOT NULL,
)

ALTER TABLE products ADD quantity INT NOT NULL DEFAULT(0)

GO

CREATE TABLE sales(
    id INT PRIMARY KEY IDENTITY,
    total NUMERIC(8,2) NOT NULL,
    productId int NOT NULL,
    FOREIGN KEY (productId) REFERENCES products(id)
)

GO

CREATE TABLE promotions(
    id INT PRIMARY KEY IDENTITY,
    dateStart DATETIME DEFAULT(CURRENT_TIMESTAMP),
    dateEnd DATETIME DEFAULT(CURRENT_TIMESTAMP),
)

GO

CREATE TABLE promotion_product(
    productId INT NOT NULL,
    promotionId INT NOT NULL,
    PRIMARY KEY(productId, promotionId),
    FOREIGN KEY (productId) REFERENCES products(id),
    FOREIGN KEY (promotionId) REFERENCES promotions(id)
)