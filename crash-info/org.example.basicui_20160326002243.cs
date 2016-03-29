S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.4
Build-Number: R720XXU2CPB7
Build-Date: 2016.02.24 22:13:42

Crash Information
Process Name: basicui
PID: 3031
Date: 2016-03-26 00:22:43+0100
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x6c

Register Information
r0   = 0x4142dec0, r1   = 0x4145edaa
r2   = 0xbea27d00, r3   = 0x00000010
r4   = 0xbea27d08, r5   = 0xbea27d00
r6   = 0x00000000, r7   = 0xbea27da4
r8   = 0xbea27ec4, r9   = 0x4004dc40
r10  = 0x4145edaa, fp   = 0xbea27cec
ip   = 0x404bb140, sp   = 0xbea27788
lr   = 0x404b1ee4, pc   = 0x404b1ee4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     16048 KB
Buffers:     15988 KB
Cached:     167720 KB
VmPeak:      68064 KB
VmSize:      68060 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15116 KB
VmRSS:       15112 KB
VmData:      12604 KB
VmStk:        1012 KB
VmExe:          20 KB
VmLib:       22740 KB
VmPTE:          42 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3031 TID = 3031
3031 3116 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40046000 r-xp /usr/lib/libappcore-efl.so.1.1
40055000 40061000 r-xp /usr/lib/libaul.so.0.1.0
4006b000 4006d000 r-xp /lib/libdl-2.13.so
40076000 40079000 r-xp /usr/lib/libbundle.so.0.1.22
40081000 40083000 r-xp /usr/lib/libdlog.so.0.0.0
4008b000 4009f000 r-xp /lib/libpthread-2.13.so
400aa000 401e4000 r-xp /usr/lib/libelementary.so.1.7.99
401fa000 402c8000 r-xp /usr/lib/libevas.so.1.7.99
402ed000 40304000 r-xp /usr/lib/libecore.so.1.7.99
4031b000 40378000 r-xp /usr/lib/libedje.so.1.7.99
40382000 40452000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40453000 40459000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40461000 40464000 r-xp /usr/lib/libsmack.so.1.0.0
4046c000 40474000 r-xp /lib/libgcc_s-4.6.so.1
40475000 40590000 r-xp /lib/libc-2.13.so
4059e000 405da000 r-xp /usr/lib/libsystemd.so.0.4.0
405e3000 405ee000 r-xp /lib/libunwind.so.8.0.1
4061b000 40632000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4063a000 40664000 r-xp /usr/lib/libdbus-1.so.3.8.12
4066d000 40672000 r-xp /usr/lib/libxdgmime.so.1.1.0
4067a000 4069c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
406a4000 406a7000 r-xp /usr/lib/libproc-stat.so.0.2.86
406af000 406b5000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406be000 40727000 r-xp /lib/libm-2.13.so
40730000 40749000 r-xp /usr/lib/libeet.so.1.7.99
4075a000 4079b000 r-xp /usr/lib/libeina.so.1.7.99
407a4000 407c6000 r-xp /usr/lib/libecore_evas.so.1.7.99
407cf000 407d4000 r-xp /usr/lib/libecore_file.so.1.7.99
407dc000 407ed000 r-xp /usr/lib/libecore_input.so.1.7.99
407f5000 407f9000 r-xp /usr/lib/libvconf.so.0.2.45
40801000 40851000 r-xp /usr/lib/libecore_x.so.1.7.99
40853000 4085c000 r-xp /usr/lib/libedbus.so.1.7.99
40864000 4087e000 r-xp /usr/lib/libecore_con.so.1.7.99
40887000 4089a000 r-xp /usr/lib/libfribidi.so.0.3.1
408a2000 408df000 r-xp /usr/lib/libharfbuzz.so.0.940.0
408e8000 40910000 r-xp /usr/lib/libfontconfig.so.1.8.0
40911000 40967000 r-xp /usr/lib/libfreetype.so.6.11.3
40973000 409c9000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d6000 409dc000 r-xp /lib/librt-2.13.so
409e5000 409ec000 r-xp /usr/lib/libembryo.so.1.7.99
409f4000 40a0b000 r-xp /usr/lib/liblua-5.1.so
40a14000 40a1a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a22000 40a23000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2b000 40a58000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a60000 40a63000 r-xp /lib/libcap.so.2.21
40a6b000 40a83000 r-xp /usr/lib/liblzma.so.5.0.3
40a8b000 40b07000 r-xp /usr/lib/libgcrypt.so.20.0.3
40b13000 40b23000 r-xp /lib/libresolv-2.13.so
40b27000 40bfa000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40c05000 40c39000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40c42000 40c58000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40c60000 40cd5000 r-xp /usr/lib/libsqlite3.so.0.8.6
40cdf000 40cf5000 r-xp /lib/libz.so.1.2.5
40cfd000 40d20000 r-xp /usr/lib/libjpeg.so.8.0.2
40d38000 40e19000 r-xp /usr/lib/libX11.so.6.3.0
40e24000 40e29000 r-xp /usr/lib/libecore_fb.so.1.7.99
40e32000 40e36000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40e3f000 40e42000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40e4a000 40e51000 r-xp /usr/lib/libXcursor.so.1.0.2
40e59000 40e5b000 r-xp /usr/lib/libXdamage.so.1.1.0
40e63000 40e65000 r-xp /usr/lib/libXcomposite.so.1.0.0
40e6d000 40e6f000 r-xp /usr/lib/libXgesture.so.7.0.0
40e77000 40e7a000 r-xp /usr/lib/libXfixes.so.3.1.0
40e82000 40e8b000 r-xp /usr/lib/libXi.so.6.1.0
40e93000 40e94000 r-xp /usr/lib/libXinerama.so.1.0.0
40e9d000 40ea3000 r-xp /usr/lib/libXrandr.so.2.2.0
40eab000 40eb1000 r-xp /usr/lib/libXrender.so.1.3.0
40eb9000 40ebd000 r-xp /usr/lib/libXtst.so.6.1.0
40ec5000 40ecf000 r-xp /usr/lib/libXext.so.6.4.0
40ed8000 40f1c000 r-xp /usr/lib/libcurl.so.4.3.0
40f25000 40f3b000 r-xp /lib/libexpat.so.1.5.2
40f45000 40f5d000 r-xp /usr/lib/libpng12.so.0.50.0
40f65000 40f82000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f8b000 4101f000 r-xp /usr/lib/libstdc++.so.6.0.16
41033000 41036000 r-xp /lib/libattr.so.1.1.0
4103e000 41049000 r-xp /usr/lib/libgpg-error.so.0.15.0
41051000 41052000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
4105a000 4105f000 r-xp /usr/lib/libffi.so.5.0.10
41067000 41069000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41072000 4113e000 r-xp /usr/lib/libxml2.so.2.7.8
4114b000 4114d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
41156000 41158000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41160000 41173000 r-xp /usr/lib/libxcb.so.1.1.0
4117d000 41186000 r-xp /usr/lib/libcares.so.2.1.0
4118f000 411bd000 r-xp /usr/lib/libidn.so.11.5.44
411c5000 41212000 r-xp /usr/lib/libssl.so.1.0.0
4121e000 413c6000 r-xp /usr/lib/libcrypto.so.1.0.0
413df000 413e1000 r-xp /usr/lib/libiri.so
413ea000 413f1000 r-xp /lib/libcrypt-2.13.so
41421000 41423000 r-xp /usr/lib/libXau.so.6.0.0
41430000 41434000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4143c000 41444000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
41445000 4144a000 r-xp /usr/lib/libappcore-common.so.1.1
41452000 41454000 r-xp /usr/lib/libiniparser.so.0
4145d000 4145f000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
41468000 41469000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41472000 41476000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4147f000 41481000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4148a000 41490000 r-xp /usr/lib/libappsvc.so.0.1.0
41498000 414bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414c5000 41594000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415aa000 415b4000 r-xp /lib/libnss_files-2.13.so
4175c000 41767000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41771000 41775000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
4177e000 4179f000 r-xp /usr/lib/libefl-extension.so.0.1.0
417a7000 417c5000 r-xp /usr/lib/libsensor.so.1.1.0
417cf000 417e1000 r-xp /usr/lib/libefl-assist.so.0.1.0
417e9000 418a1000 r-xp /usr/lib/libcairo.so.2.11200.14
418ac000 418b3000 r-xp /usr/lib/libsensord-share.so
418bb000 418cd000 r-xp /usr/lib/libtts.so
418d5000 418f6000 r-xp /usr/lib/libui-extension.so.0.1.0
418ff000 41906000 r-xp /usr/lib/libtbm.so.1.0.0
4190e000 4191c000 r-xp /usr/lib/libGLESv2.so.2.0
41925000 4192b000 r-xp /usr/lib/libxcb-render.so.0.0.0
41933000 41936000 r-xp /usr/lib/libEGL.so.1.4
4193e000 41943000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4194b000 4194e000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41956000 4195e000 r-xp /usr/lib/libdrm.so.2.4.0
41966000 4196b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41974000 41979000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41981000 41983000 r-xp /usr/lib/libdri2.so.0.0.0
4198b000 41990000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41998000 4199c000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
419a4000 41ad7000 rw-p [heap]
41ad7000 41c14000 r-xp /usr/lib/libicui18n.so.51.1
41c24000 41d08000 r-xp /usr/lib/libicuuc.so.51.1
432a4000 432c5000 r-xp /usr/lib/libexif.so.12.3.3
432d8000 433a2000 r-xp /usr/lib/libCOREGL.so.4.0
435b4000 435bf000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
435c8000 435df000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
436ec000 436ee000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
436f7000 43ef6000 rwxp [stack:3116]
bea1d000 beb13000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3031)
Call Stack Count: 3
 0: _IO_vfprintf + 0x20 (0x404b1ee4) [/lib/libc.so.6] + 0x3cee4
 1: _IO_fprintf + 0x1c (0x404bb15c) [/lib/libc.so.6] + 0x4615c
 2: save_data + 0xc0 (0x4145eb55) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1b55
End of Call Stack

Package Information
Package Name: org.example.basicui
Package ID : org.example.basicui
Version: 1.0.0
Package Type: rpm
App Name: basicui
App ID: org.example.basicui
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
l-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.470+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.470+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847263
03-26 00:22:25.470+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.470+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.470+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.520+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.520+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.520+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847311
03-26 00:22:25.520+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.520+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.520+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.560+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.560+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.560+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847352
03-26 00:22:25.560+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.560+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.560+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.610+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.610+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.610+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847402
03-26 00:22:25.610+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.610+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.610+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.665+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.665+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.665+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847454
03-26 00:22:25.665+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.665+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.665+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.725+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.725+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.725+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847518
03-26 00:22:25.725+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.725+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.725+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.835+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.835+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.835+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847626
03-26 00:22:25.835+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.835+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.835+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.870+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.870+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.870+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847661
03-26 00:22:25.870+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.870+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.870+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.900+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.900+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.900+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847690
03-26 00:22:25.900+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.900+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.900+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.940+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.940+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.940+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847730
03-26 00:22:25.940+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.940+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.940+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.975+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.975+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.975+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847767
03-26 00:22:25.975+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.975+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.975+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.030+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.030+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.030+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847819
03-26 00:22:26.030+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.030+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.030+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.095+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.095+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.095+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847884
03-26 00:22:26.095+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.095+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.095+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.180+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.180+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.180+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847972
03-26 00:22:26.180+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.180+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.180+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.405+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.405+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.405+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848194
03-26 00:22:26.405+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.405+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.405+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.465+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.465+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.465+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848257
03-26 00:22:26.465+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.465+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.465+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.510+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.510+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.510+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848304
03-26 00:22:26.510+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.515+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.515+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.560+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.560+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.560+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848349
03-26 00:22:26.560+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.560+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.560+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.600+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.600+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.600+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848393
03-26 00:22:26.600+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.600+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.600+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.650+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.650+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.650+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848443
03-26 00:22:26.650+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.650+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.650+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.805+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.805+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.805+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848594
03-26 00:22:26.805+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.805+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.805+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.840+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.840+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.840+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848630
03-26 00:22:26.840+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.840+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.840+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.875+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.875+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.875+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848668
03-26 00:22:26.875+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.880+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.880+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.920+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.920+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.920+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848709
03-26 00:22:26.920+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.920+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.920+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.970+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.970+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.970+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848762
03-26 00:22:26.970+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.970+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.970+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:36.400+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:22:36.400+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=858191 button=1 downs=1
03-26 00:22:36.400+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [154, 121]
03-26 00:22:36.835+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=858618 button=1 downs=0
03-26 00:22:36.835+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [154, 121]->[189, 284]
03-26 00:22:37.220+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:22:37.225+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=859014 button=1 downs=1
03-26 00:22:37.225+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [220, 83]
03-26 00:22:37.330+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=859123 button=1 downs=0
03-26 00:22:37.330+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [220, 83]->[220, 84]
03-26 00:22:37.330+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:22:37.330+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[15]
03-26 00:22:37.350+0100 E/APPS    (  681): AppsViewNecklace.cpp: runEmptyBoxBackwardAnimation(3604) >  (!__pEmptyBox) -> runEmptyBoxBackwardAnimation() return
03-26 00:22:37.570+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:38.355+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.355+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.355+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.355+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.355+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 860145
03-26 00:22:38.355+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:38.440+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.440+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.440+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 860232
03-26 00:22:38.440+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:38.440+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.440+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.445+0100 I/RESOURCED(  492): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
03-26 00:22:38.445+0100 I/RESOURCED(  492): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
03-26 00:22:38.525+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.525+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.525+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 860318
03-26 00:22:38.525+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:38.530+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.530+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.640+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.640+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.640+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 860430
03-26 00:22:38.640+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:38.640+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.640+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:39.140+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:22:39.140+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=860930 button=1 downs=1
03-26 00:22:39.140+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [113, 75]
03-26 00:22:39.225+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=861017 button=1 downs=0
03-26 00:22:39.225+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [113, 75]->[119, 77]
03-26 00:22:39.225+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:22:39.225+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[16]
03-26 00:22:39.235+0100 E/APPS    (  681): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(3513) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
03-26 00:22:39.465+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:40.170+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.170+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 861961
03-26 00:22:40.170+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:40.170+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.170+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.170+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 862049
03-26 00:22:40.260+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:40.260+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.260+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.260+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.445+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.445+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 862238
03-26 00:22:40.445+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:40.450+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.450+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.450+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.705+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.705+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 862496
03-26 00:22:40.705+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:40.705+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.705+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.705+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.815+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.815+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.815+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 862607
03-26 00:22:40.815+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:40.815+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.815+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.910+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.910+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 862702
03-26 00:22:40.910+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:40.910+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.910+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.910+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.065+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.065+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.065+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 862857
03-26 00:22:41.065+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.065+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.065+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.180+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.180+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.180+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 862972
03-26 00:22:41.180+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.180+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.180+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.550+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.555+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.555+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863344
03-26 00:22:41.555+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.555+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.555+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.585+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.585+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.585+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863378
03-26 00:22:41.585+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.585+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.585+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.625+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.625+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.625+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863417
03-26 00:22:41.625+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.625+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.625+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.675+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.675+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.675+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863464
03-26 00:22:41.675+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.675+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.675+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.745+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.745+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.745+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863537
03-26 00:22:41.745+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.745+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.745+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.825+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.825+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.825+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863618
03-26 00:22:41.825+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.830+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.830+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.965+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.965+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.965+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863755
03-26 00:22:41.965+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.965+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.965+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.020+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.025+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.025+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863814
03-26 00:22:42.025+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.025+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.025+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.080+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.080+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.080+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863869
03-26 00:22:42.080+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.080+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.080+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.115+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.115+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.115+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863908
03-26 00:22:42.115+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.115+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.115+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.165+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.165+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.165+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863957
03-26 00:22:42.165+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.165+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.165+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.315+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.315+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.315+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 864106
03-26 00:22:42.315+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.315+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.315+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.335+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.335+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.335+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 864127
03-26 00:22:42.335+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.335+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.335+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.365+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.365+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.365+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 864157
03-26 00:22:42.365+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.365+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.365+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.455+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.455+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.455+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 864245
03-26 00:22:42.455+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.455+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.455+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.515+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.515+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.515+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 864307
03-26 00:22:42.515+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.515+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.515+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.625+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.625+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.625+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 864415
03-26 00:22:42.625+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.625+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.625+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:43.470+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:22:43.470+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=865261 button=1 downs=1
03-26 00:22:43.470+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [88, 266]
03-26 00:22:43.495+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=865283 button=1 downs=0
03-26 00:22:43.495+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [88, 266]->[109, 258]
03-26 00:22:43.495+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[21]
03-26 00:22:43.495+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,21]
03-26 00:22:43.495+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:22:43.495+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
03-26 00:22:43.495+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:22:43.495+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 681
03-26 00:22:43.495+0100 I/AUL_AMD (  491): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
03-26 00:22:43.510+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:22:43.510+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:22:43.510+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:22:43.510+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
03-26 00:22:43.510+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:22:43.545+0100 I/efl-extension( 3031): efl_extension.c: eext_mod_init(40) > Init
03-26 00:22:43.545+0100 I/UXT     ( 3031): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:22:43.550+0100 I/CAPI_APPFW_APPLICATION( 3031): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:22:43.550+0100 I/CAPI_APPFW_APPLICATION( 3031): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:22:43.595+0100 E/TBM     ( 3031): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:22:43.615+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:22:43.615+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:22:43.650+0100 E/EFL     ( 3031): ecore_evas<3031> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:22:43.800+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 1103031626173145894816
