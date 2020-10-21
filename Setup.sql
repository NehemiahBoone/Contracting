
CREATE TABLE profiles(
  id VARCHAR(255) NOT NULL,
  email VARCHAR(255) NOT NULL,
  name VARCHAR(255),
  picture VARCHAR(255),
  PRIMARY KEY (id)
);


CREATE TABLE jobs
(
  id INT NOT NULL AUTO_INCREMENT,
  location VARCHAR(255) NOT NULL,
  description VARCHAR(255),
  contact VARCHAR(255) NOT NULL,
  hourlyPay DECIMAL(6, 2) NOT NULL,
  creatorId VARCHAR(255) NOT NULL,
  PRIMARY KEY (id),

  FOREIGN KEY (creatorId)
    REFERENCES profiles (id)
    ON DELETE CASCADE
);

CREATE TABLE contractors
(
  id INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(255),
  address VARCHAR(255),
  contact VARCHAR(255),
  skills VARCHAR(255),
  creatorId VARCHAR(255) NOT NULL,
  PRIMARY KEY (id),

  FOREIGN KEY (creatorId)
    REFERENCES profiles (id)
    ON DELETE CASCADE
);









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

/* CREATE TABLE bids
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
); */

-- INSERT INTO contractors (name, address, contact, skills) VALUES ("Nehemiah", "789 W Arhcehrui work", "208-972-1452", "Vue.js, javascript");
