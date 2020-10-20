CREATE TABLE IF NOT EXISTS jobs
(
  location VARCHAR(255) NOT NULL,
  description VARCHAR(255),
  contact VARCHAR(255) NOT NULL,
  hourlyPay DECIMAL(6, 2) NOT NULL,
  id INT NOT NULL AUTO_INCREMENT,

  PRIMARY KEY (id)

);
CREATE TABLE IF NOT EXISTS contractors
(
  name VARCHAR(255) NOT NULL,
  address VARCHAR(255),
  contact VARCHAR(255) NOT NULL,
  skills VARCHAR(255) NOT NULL,
  id INT NOT NULL AUTO_INCREMENT,

  PRIMARY KEY (id)

);

INSERT INTO contractors (name, address, contact, skills) VALUES ("Nehemiah", "789 W Arhcehrui work", "208-972-1452", "Vue.js, javascript");
