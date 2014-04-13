/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50616
Source Host           : localhost:3306
Source Database       : v_0_0_1

Target Server Type    : MYSQL
Target Server Version : 50616
File Encoding         : 65001

Date: 2014-04-13 05:56:14
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for account
-- ----------------------------
DROP TABLE IF EXISTS `account`;
CREATE TABLE `account` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `points` int(11) NOT NULL DEFAULT '0',
  `admin` int(1) NOT NULL DEFAULT '0',
  `group_id` int(11) DEFAULT '0' COMMENT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=75 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of account
-- ----------------------------
INSERT INTO `account` VALUES ('1', 'admin', 'admin', 'Admin', '0', '1', '1');
INSERT INTO `account` VALUES ('69', 'tdr', 'tdr', 'TDR', '255', '1', '1');
INSERT INTO `account` VALUES ('70', 'tdr2', 'tdr', 'TDR2', '65', '0', '2');
INSERT INTO `account` VALUES ('71', 'usr2meu', 'pass', 'USeR2mea', '6', '0', '3');
INSERT INTO `account` VALUES ('72', 'usr3', 'pass', 'User3', '6', '0', '3');
INSERT INTO `account` VALUES ('74', 'usr4', 'pass', 'User4', '0', '0', '23');

-- ----------------------------
-- Table structure for category
-- ----------------------------
DROP TABLE IF EXISTS `category`;
CREATE TABLE `category` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of category
-- ----------------------------
INSERT INTO `category` VALUES ('1', 'categorie1');
INSERT INTO `category` VALUES ('2', 'categorie2');
INSERT INTO `category` VALUES ('3', 'categorie33');
INSERT INTO `category` VALUES ('4', 'categorie434');
INSERT INTO `category` VALUES ('5', 'categorie5');
INSERT INTO `category` VALUES ('6', 'categorie6');
INSERT INTO `category` VALUES ('12', 'categoria ');

-- ----------------------------
-- Table structure for group
-- ----------------------------
DROP TABLE IF EXISTS `group`;
CREATE TABLE `group` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `initial_points` int(11) DEFAULT '5',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of group
-- ----------------------------
INSERT INTO `group` VALUES ('1', 'groupvvv', '50');
INSERT INTO `group` VALUES ('2', 'grupa editata', '6');
INSERT INTO `group` VALUES ('3', 'grupa3', '5');
INSERT INTO `group` VALUES ('4', 'grupa4', '5');

-- ----------------------------
-- Table structure for product
-- ----------------------------
DROP TABLE IF EXISTS `product`;
CREATE TABLE `product` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `price` double DEFAULT NULL,
  `vote_points` int(11) NOT NULL DEFAULT '0',
  `category` int(11) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of product
-- ----------------------------
INSERT INTO `product` VALUES ('1', 'product1', '3', '16', '1');
INSERT INTO `product` VALUES ('2', 'product2', '45', '170', '1');
INSERT INTO `product` VALUES ('7', 'product7', '21', '37', '2');
INSERT INTO `product` VALUES ('8', 'product8', '24', '29', '2');
INSERT INTO `product` VALUES ('12', 'product9', '0', '7', '12');
INSERT INTO `product` VALUES ('14', 'product11', '0', '4', '12');
INSERT INTO `product` VALUES ('15', 'productnew', '12', '0', '6');
INSERT INTO `product` VALUES ('16', 'altProd', '69', '43', '6');

-- ----------------------------
-- Table structure for setting
-- ----------------------------
DROP TABLE IF EXISTS `setting`;
CREATE TABLE `setting` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `key` varchar(255) DEFAULT NULL,
  `value` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of setting
-- ----------------------------
INSERT INTO `setting` VALUES ('1', 'welcome_message', 'Welcome User!');
INSERT INTO `setting` VALUES ('2', 'admin_welcome_message', 'Welcome Mr. Administrator!');

-- ----------------------------
-- Table structure for votes
-- ----------------------------
DROP TABLE IF EXISTS `votes`;
CREATE TABLE `votes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `product_id` int(11) DEFAULT NULL,
  `points` int(11) DEFAULT NULL,
  `time` datetime DEFAULT NULL,
  `account_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of votes
-- ----------------------------
INSERT INTO `votes` VALUES ('11', '1', '5', '2014-02-12 21:04:55', '70');
INSERT INTO `votes` VALUES ('12', '1', '1', '2014-02-12 21:04:58', '70');
INSERT INTO `votes` VALUES ('13', '2', '5', '2014-04-12 21:19:48', '70');
INSERT INTO `votes` VALUES ('14', '1', '5', '2014-04-12 21:19:50', '70');
INSERT INTO `votes` VALUES ('15', '2', '5', '2014-04-12 21:19:53', '70');
INSERT INTO `votes` VALUES ('16', '8', '5', '2014-04-12 21:19:59', '70');
INSERT INTO `votes` VALUES ('17', '7', '5', '2014-03-12 21:20:01', '70');
INSERT INTO `votes` VALUES ('18', '7', '5', '2014-03-12 21:20:03', '70');
INSERT INTO `votes` VALUES ('19', '7', '5', '2014-04-12 21:20:05', '70');
INSERT INTO `votes` VALUES ('20', '16', '5', '2014-03-12 21:20:06', '70');
INSERT INTO `votes` VALUES ('21', '16', '5', '2014-02-12 21:20:08', '70');
INSERT INTO `votes` VALUES ('22', '16', '5', '2014-03-12 21:20:13', '70');
INSERT INTO `votes` VALUES ('23', '16', '15', '2014-03-12 21:20:17', '70');
INSERT INTO `votes` VALUES ('24', '16', '5', '2014-04-12 21:20:46', '70');
INSERT INTO `votes` VALUES ('25', '16', '9', '2014-04-12 21:20:48', '70');
INSERT INTO `votes` VALUES ('26', '16', '4', '2014-04-12 21:20:49', '70');
INSERT INTO `votes` VALUES ('27', '16', '8', '2014-03-12 21:20:17', null);
INSERT INTO `votes` VALUES ('28', '16', '7', '2014-05-12 21:20:17', null);
INSERT INTO `votes` VALUES ('29', '16', '12', '2014-05-12 21:20:17', null);
INSERT INTO `votes` VALUES ('30', '16', '5', '2014-05-12 21:20:17', null);
INSERT INTO `votes` VALUES ('31', '16', '13', '2014-05-12 21:20:17', null);
INSERT INTO `votes` VALUES ('32', '16', '11', '2014-04-12 21:20:17', null);
INSERT INTO `votes` VALUES ('33', '16', '15', '2014-05-12 21:20:17', null);
INSERT INTO `votes` VALUES ('34', '16', '58', '2014-03-12 21:20:17', null);
INSERT INTO `votes` VALUES ('35', '2', '5', '2014-04-13 05:01:29', '70');
