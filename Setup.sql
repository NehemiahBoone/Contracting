-- CREATE TABLE IF NOT EXISTS jobs
-- (
--   location VARCHAR(255) NOT NULL,
--   description VARCHAR(255),
--   contact VARCHAR(255) NOT NULL,
--   hourlyPay DECIMAL(6, 2) NOT NULL,
--   id INT NOT NULL AUTO_INCREMENT,

--   PRIMARY KEY (id)

-- );
-- CREATE TABLE IF NOT EXISTS contractors
-- (
--   name VARCHAR(255) NOT NULL,
--   address VARCHAR(255),
--   contact VARCHAR(255) NOT NULL,
--   skills VARCHAR(255) NOT NULL,
--   id INT NOT NULL AUTO_INCREMENT,

--   PRIMARY KEY (id)

-- );

CREATE TABLE bids
(
  id INT AUTO_INCREMENT,
  jobId INT,
  contractorId INT,

  PRIMARY KEY (id),

  FOREIGN KEY(jobId)
    REFERENCES jobs (id)
    ON DELETE CASCADE,

  FOREIGN KEY(contractorId)
    REFERENCES contractors (id)
    ON DELETE CASCADE
);

-- INSERT INTO contractors (name, address, contact, skills) VALUES ("Nehemiah", "789 W Arhcehrui work", "208-972-1452", "Vue.js, javascript");
