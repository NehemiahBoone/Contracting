CREATE TABLE IF NOT EXISTS jobs
(
  location VARCHAR(255) NOT NULL,
  description VARCHAR(255),
  contact VARCHAR(255) NOT NULL,
  hourlyPay DECIMAL(6, 2) NOT NULL,
  id INT NOT NULL AUTO_INCREMENT,

  PRIMARY KEY (id)

);

-- INSERT INTO jobs (location, description, contact, hourlyPay) VALUES ("Meridian", "Construction work", "208-972-1452", 19.50);
SELECT * FROM jobs;