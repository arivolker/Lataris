/*
SQLyog Ultimate v12.09 (64 bit)
MySQL - 10.4.14-MariaDB : Database - db_login
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
/*Table structure for table `menus` */

CREATE TABLE `menus` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `order` int(11) DEFAULT NULL,
  `name_menu` varchar(50) DEFAULT NULL,
  `parent` int(11) DEFAULT NULL,
  `active` tinyint(4) DEFAULT NULL,
  `controller` varchar(150) DEFAULT NULL,
  `desc` varchar(150) DEFAULT NULL,
  `url` varchar(100) DEFAULT NULL,
  `icon` varchar(25) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `sts_add` tinyint(1) DEFAULT NULL,
  `sts_edit` tinyint(1) DEFAULT NULL,
  `sts_delete` tinyint(1) DEFAULT NULL,
  `sts_print` tinyint(1) DEFAULT NULL,
  `sts_download` tinyint(1) DEFAULT NULL,
  `id_customer` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb4;

/*Data for the table `menus` */

insert  into `menus`(`id`,`order`,`name_menu`,`parent`,`active`,`controller`,`desc`,`url`,`icon`,`created_at`,`sts_add`,`sts_edit`,`sts_delete`,`sts_print`,`sts_download`,`id_customer`) values (1,1,'Data Imaging',0,1,NULL,NULL,NULL,'fa fa-file-image-o','2022-12-28 10:20:38',0,0,0,0,0,1),(2,1,'List Imaging',1,1,'UploadController',NULL,'imaging.listupload',NULL,'2022-12-28 10:20:38',0,0,0,0,0,0),(4,2,'Report',0,1,NULL,NULL,'','fa fa-line-chart','2022-12-28 10:20:38',0,0,0,0,0,1),(8,1,'Detail',4,1,'ReportController',NULL,'report.list',NULL,'2022-12-28 10:20:38',0,0,0,0,0,1),(9,2,'Summary',4,1,'ReportController',NULL,'report.summary',NULL,'2022-12-28 10:20:38',0,0,0,0,0,1),(10,3,'Mutation Box',0,1,NULL,NULL,'','fa fa-exchange','2022-12-28 10:20:38',0,0,0,0,0,0),(11,1,'Form Mutation',10,1,'MutationController',NULL,'mutation.form',NULL,'2022-12-28 10:20:38',0,0,0,0,0,0),(12,2,'List Mutation',10,1,'ListController',NULL,'mutation.list',NULL,'2022-12-28 10:20:38',0,0,0,0,0,0),(13,4,'Master',0,1,NULL,NULL,NULL,'fa fa-database','2022-12-28 10:20:38',0,0,0,0,0,1),(14,1,'Users',13,1,'UsersController',NULL,'master.users',NULL,'2022-12-28 10:20:38',0,0,0,0,0,1),(15,2,'Customer',13,1,'CustomerController',NULL,'master.customer',NULL,'2022-12-28 10:20:38',0,0,0,0,0,0),(16,3,'Product',13,1,'ProductController',NULL,'master.product',NULL,'2022-12-28 10:20:38',0,0,0,0,0,0),(17,5,'Settings',0,1,NULL,NULL,NULL,'fa fa-gear','2022-12-28 10:20:38',0,0,0,0,0,0),(18,1,'Database',17,1,NULL,NULL,NULL,NULL,'2022-12-28 10:20:38',0,0,0,0,0,0),(20,4,'Pos Location',13,1,'PosLocController',NULL,'master.posloc',NULL,'2022-12-28 10:20:38',0,0,0,0,0,0),(21,2,'Data NB',1,1,'NBController',NULL,'imaging.nb.list',NULL,'2022-12-28 10:20:38',0,0,0,0,0,1),(22,3,'Data POS',1,1,'POSController',NULL,'imaging.pos.list',NULL,'2022-12-28 10:20:38',0,0,0,0,0,1),(23,4,'Data Claim',1,1,'CLAIMController',NULL,'imaging.claim.list',NULL,'2022-12-28 10:20:38',0,0,0,0,0,1),(24,6,'File Management',0,1,NULL,NULL,NULL,'fa fa-file','2022-12-28 10:20:38',0,0,0,0,0,0),(25,7,'Profile',0,1,NULL,NULL,NULL,'fa fa-user','2022-12-28 10:20:38',0,0,0,0,0,1),(26,1,'Change Password',25,1,'ProfileController',NULL,'profile.changepass',NULL,'2022-12-28 10:20:38',0,0,0,0,0,1),(27,6,'System Email',0,1,NULL,NULL,NULL,'fa fa-send','2022-12-28 10:20:38',0,0,0,0,0,1),(28,1,'Start Email',27,1,'UploadMailController',NULL,'startmail.list',NULL,'2022-12-28 10:20:38',0,0,0,0,0,0),(29,2,'Progress Email',27,1,'ProgressController',NULL,'progress.list',NULL,'2022-12-28 10:20:38',0,0,0,0,0,1),(30,6,'Report Email',0,1,NULL,NULL,NULL,NULL,'2022-12-28 10:20:38',0,0,0,0,0,1),(31,1,'Summary',30,1,NULL,NULL,NULL,NULL,'2022-12-28 10:20:38',0,0,0,0,0,1),(32,1,'Body Email',17,1,'BodyMailController',NULL,'settings.bodyemail',NULL,'2022-12-28 10:20:38',0,0,0,0,0,0),(33,2,'Variable Field',17,1,'VariableController',NULL,'settings.variablefield',NULL,'2022-12-28 10:20:38',0,0,0,0,0,0),(35,0,'Home',0,1,'HomeController',NULL,'home','fa fa-home','2022-12-28 10:20:38',0,0,0,0,0,1),(36,1,'Job Tracking',0,1,'TrackingJobController',NULL,'trackjob','fa fa-print','2022-12-28 10:20:38',0,0,0,0,0,1),(39,3,'Log Activity',4,1,'ReportController',NULL,'report.logact',NULL,'2022-12-28 10:20:38',0,0,0,0,0,1),(43,4,'User Active',4,1,'ReportController',NULL,'report.useractive',NULL,'2022-12-28 10:20:38',0,0,0,0,0,1);

/*Table structure for table `menus_to_users` */

CREATE TABLE `menus_to_users` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) DEFAULT NULL,
  `menu_id` int(11) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `sts_add` int(1) DEFAULT NULL,
  `sts_edit` int(1) DEFAULT NULL,
  `sts_delete` int(1) DEFAULT NULL,
  `sts_print` int(1) DEFAULT NULL,
  `sts_download` int(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=561 DEFAULT CHARSET=utf8mb4;

/*Data for the table `menus_to_users` */

insert  into `menus_to_users`(`id`,`user_id`,`menu_id`,`created_at`,`sts_add`,`sts_edit`,`sts_delete`,`sts_print`,`sts_download`) values (24,6,1,'2021-06-18 16:34:20',NULL,NULL,NULL,NULL,NULL),(25,6,4,'2021-06-18 16:34:21',NULL,NULL,NULL,NULL,NULL),(26,6,8,'2021-06-18 16:34:22',NULL,NULL,NULL,NULL,NULL),(27,6,9,'2021-06-18 16:34:24',NULL,NULL,NULL,NULL,NULL),(28,6,21,'2021-06-18 16:34:29',NULL,NULL,NULL,NULL,NULL),(29,6,22,'2021-06-18 16:34:29',NULL,NULL,NULL,NULL,NULL),(30,6,23,'2021-06-18 16:34:30',NULL,NULL,NULL,NULL,NULL),(222,2,35,'2021-12-28 07:43:16',NULL,NULL,NULL,NULL,NULL),(223,2,1,'2021-12-28 07:43:16',NULL,NULL,NULL,NULL,NULL),(224,2,21,'2021-12-28 07:43:16',NULL,NULL,NULL,NULL,NULL),(225,2,22,'2021-12-28 07:43:16',NULL,NULL,NULL,NULL,NULL),(226,2,23,'2021-12-28 07:43:16',NULL,NULL,NULL,NULL,NULL),(227,2,4,'2021-12-28 07:43:16',NULL,NULL,NULL,NULL,NULL),(228,2,8,'2021-12-28 07:43:16',NULL,NULL,NULL,NULL,NULL),(229,2,9,'2021-12-28 07:43:16',NULL,NULL,NULL,NULL,NULL),(230,2,25,'2021-12-28 07:43:16',NULL,NULL,NULL,NULL,NULL),(231,2,26,'2021-12-28 07:43:16',NULL,NULL,NULL,NULL,NULL),(284,8,35,'2022-01-07 10:47:53',NULL,NULL,NULL,NULL,NULL),(285,8,1,'2022-01-07 10:47:53',NULL,NULL,NULL,NULL,NULL),(286,8,21,'2022-01-07 10:47:54',NULL,NULL,NULL,NULL,NULL),(287,8,22,'2022-01-07 10:47:54',NULL,NULL,NULL,NULL,NULL),(288,8,23,'2022-01-07 10:47:54',NULL,NULL,NULL,NULL,NULL),(289,8,36,'2022-01-07 10:47:54',NULL,NULL,NULL,NULL,NULL),(290,8,4,'2022-01-07 10:47:54',NULL,NULL,NULL,NULL,NULL),(291,8,8,'2022-01-07 10:47:54',NULL,NULL,NULL,NULL,NULL),(292,8,9,'2022-01-07 10:47:54',NULL,NULL,NULL,NULL,NULL),(293,8,25,'2022-01-07 10:47:54',NULL,NULL,NULL,NULL,NULL),(294,8,26,'2022-01-07 10:47:54',NULL,NULL,NULL,NULL,NULL),(457,12,35,'2022-04-21 02:58:43',NULL,NULL,NULL,NULL,NULL),(458,12,1,'2022-04-21 02:58:43',NULL,NULL,NULL,NULL,NULL),(459,12,2,'2022-04-21 02:58:43',NULL,NULL,NULL,NULL,NULL),(460,12,21,'2022-04-21 02:58:43',NULL,NULL,NULL,NULL,NULL),(461,12,22,'2022-04-21 02:58:43',NULL,NULL,NULL,NULL,NULL),(462,12,23,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(463,12,36,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(464,12,4,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(465,12,8,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(466,12,9,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(467,12,39,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(468,12,40,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(469,12,10,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(470,12,11,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(471,12,12,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(472,12,13,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(473,12,14,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(474,12,15,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(475,12,16,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(476,12,20,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(477,12,17,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(478,12,18,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(479,12,32,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(480,12,33,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(481,12,27,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(482,12,28,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(483,12,29,'2022-04-21 02:58:44',NULL,NULL,NULL,NULL,NULL),(484,12,30,'2022-04-21 02:58:45',NULL,NULL,NULL,NULL,NULL),(485,12,31,'2022-04-21 02:58:45',NULL,NULL,NULL,NULL,NULL),(486,12,24,'2022-04-21 02:58:45',NULL,NULL,NULL,NULL,NULL),(487,12,25,'2022-04-21 02:58:45',NULL,NULL,NULL,NULL,NULL),(488,12,26,'2022-04-21 02:58:45',NULL,NULL,NULL,NULL,NULL),(540,1,35,'2022-12-27 07:42:30',NULL,NULL,NULL,NULL,NULL),(541,1,36,'2022-12-27 07:42:30',NULL,NULL,NULL,NULL,NULL),(542,1,1,'2022-12-27 07:42:30',NULL,NULL,NULL,NULL,NULL),(543,1,2,'2022-12-27 07:42:30',NULL,NULL,NULL,NULL,NULL),(544,1,21,'2022-12-27 07:42:30',NULL,NULL,NULL,NULL,NULL),(545,1,22,'2022-12-27 07:42:30',NULL,NULL,NULL,NULL,NULL),(546,1,23,'2022-12-27 07:42:30',NULL,NULL,NULL,NULL,NULL),(547,1,4,'2022-12-27 07:42:30',NULL,NULL,NULL,NULL,NULL),(548,1,8,'2022-12-27 07:42:30',NULL,NULL,NULL,NULL,NULL),(549,1,9,'2022-12-27 07:42:30',NULL,NULL,NULL,NULL,NULL),(550,1,39,'2022-12-27 07:42:30',NULL,NULL,NULL,NULL,NULL),(551,1,43,'2022-12-27 07:42:30',NULL,NULL,NULL,NULL,NULL),(552,1,13,'2022-12-27 07:42:30',NULL,NULL,NULL,NULL,NULL),(553,1,14,'2022-12-27 07:42:31',NULL,NULL,NULL,NULL,NULL),(554,1,15,'2022-12-27 07:42:31',NULL,NULL,NULL,NULL,NULL),(555,1,16,'2022-12-27 07:42:31',NULL,NULL,NULL,NULL,NULL),(556,1,20,'2022-12-27 07:42:31',NULL,NULL,NULL,NULL,NULL),(557,1,27,'2022-12-27 07:42:31',NULL,NULL,NULL,NULL,NULL),(558,1,29,'2022-12-27 07:42:31',NULL,NULL,NULL,NULL,NULL),(559,1,25,'2022-12-27 07:42:31',NULL,NULL,NULL,NULL,NULL),(560,1,26,'2022-12-27 07:42:31',NULL,NULL,NULL,NULL,NULL);

/*Table structure for table `pegawai` */

CREATE TABLE `pegawai` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `username` varchar(10) DEFAULT NULL,
  `password` varchar(250) DEFAULT NULL,
  `level` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `pegawai` */

insert  into `pegawai`(`id`,`username`,`password`,`level`) values (1,'aris','123','admin'),(2,'member','123','member');

/*Table structure for table `setup_master_menu` */

CREATE TABLE `setup_master_menu` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `modul` varchar(50) DEFAULT NULL,
  `menu` varchar(50) DEFAULT NULL,
  `submenu` varchar(50) DEFAULT NULL,
  `desc` varchar(50) DEFAULT NULL,
  `urut` int(11) DEFAULT NULL,
  `induk` varchar(50) DEFAULT NULL,
  `aktif` int(11) DEFAULT NULL,
  `aksi` varchar(50) DEFAULT NULL,
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

/*Data for the table `setup_master_menu` */

insert  into `setup_master_menu`(`id`,`modul`,`menu`,`submenu`,`desc`,`urut`,`induk`,`aktif`,`aksi`) values (1,'modula','file','','File',1,'',1,''),(2,'modula','open','','Open',1,'file',1,'file-open'),(3,'modula','edit','','Edit',2,'',1,''),(4,'modula','copy','','Copy',1,'edit',1,'edit-copy'),(5,'modula','paste','','Paste',2,'edit',1,'edit-paste');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
