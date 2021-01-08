CREATE TABLE IF NOT EXISTS `book` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `title` varchar(100) NOT NULL,
  `author` varchar(80) NOT NULL,
  PRIMARY KEY (`id`)
)