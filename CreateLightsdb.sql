-- Table: lights

-- DROP TABLE lights;

CREATE TABLE lights
(
  uuid integer NOT NULL,
  lat integer,
  longi integer,
  lux integer,
  CONSTRAINT uuid PRIMARY KEY (uuid)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE lights
  OWNER TO postgres;
