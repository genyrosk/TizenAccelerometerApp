S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:37

Crash Information
Process Name: basicui
PID: 4430
Date: 2016-03-23 18:42:45+0900
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb45c7196

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000012, esi = 0x00000000
ebp = 0xbfa08158, esp = 0xbfa07f58
eax = 0xb45c7196, ebx = 0xb7619ff4
ecx = 0x00000032, edx = 0xbfa0871c
eip = 0xb74ed3c0

Memory Information
MemTotal:      124 KB
MemFree:        28 KB
Buffers:        13 KB
Cached:     137168 KB
VmPeak:      72376 KB
VmSize:      72376 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14648 KB
VmRSS:       14648 KB
VmData:      12372 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       31800 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4430 TID = 4430
4430 4434 

Maps Information
b35a7000 b35a8000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b35a9000 b35ab000 r-xp /usr/lib/elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so
b35ac000 b35d0000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b3772000 b3775000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b3776000 b3784000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b3785000 b3794000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b3f9b000 b3f9e000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3f9f000 b3fa2000 r-xp /usr/lib/libdri2.so.0.0.0
b3fa3000 b3fae000 r-xp /usr/lib/libdrm.so.2.4.0
b3faf000 b3fb8000 r-xp /usr/lib/libtbm.so.1.0.0
b3fb9000 b3fc0000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3fc1000 b3fca000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3fcb000 b3fd2000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3fd3000 b3fd9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3fda000 b3fe2000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3fe3000 b3fe7000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b3fe8000 b4005000 r-xp /usr/lib/libtts.so
b4006000 b414a000 r-xp /usr/lib/libcairo.so.2.11200.14
b414e000 b4166000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4167000 b4188000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4189000 b4199000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b419a000 b41a5000 r-xp /lib/libnss_files-2.13.so
b43e6000 b440d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b440e000 b4433000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4434000 b4555000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4565000 b459b000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b459d000 b45a0000 r-xp /usr/lib/libiniparser.so.0
b45a2000 b45ac000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b45ad000 b45b6000 r-xp /usr/lib/libappsvc.so.0.1.0
b45b7000 b45ba000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b45bb000 b45bd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45be000 b45c4000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b45c5000 b45c8000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
b45c9000 b45cf000 r-xp /usr/lib/libogg.so.0.7.1
b45d0000 b45fb000 r-xp /usr/lib/libvorbis.so.0.4.3
b45fc000 b46e7000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b46f5000 b46f7000 r-xp /usr/lib/libXau.so.6.0.0
b46f8000 b4758000 r-xp /usr/lib/libssl.so.1.0.0
b475d000 b478e000 r-xp /usr/lib/libidn.so.11.5.44
b478f000 b479f000 r-xp /usr/lib/libcares.so.2.1.0
b47a0000 b4809000 r-xp /usr/lib/libsndfile.so.1.0.25
b480f000 b4819000 r-xp /usr/lib/libsensord-share.so
b481a000 b4840000 r-xp /lib/libexpat.so.1.5.2
b4842000 b4869000 r-xp /usr/lib/libpng12.so.0.50.0
b486a000 b488a000 r-xp /usr/lib/libxcb.so.1.1.0
b488b000 b48fa000 r-xp /usr/lib/libcurl.so.4.3.0
b48fc000 b4907000 r-xp /usr/lib/libethumb.so.1.7.99
b5e67000 b5f3f000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f4b000 b5f4e000 r-xp /usr/lib/libctxdata.so.0.0.0
b5f4f000 b5f65000 r-xp /usr/lib/libremix.so.0.0.0
b5f66000 b5f68000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f69000 b5f95000 r-xp /usr/lib/liblua-5.1.so
b5f96000 b5fa0000 r-xp /usr/lib/libembryo.so.1.7.99
b5fa1000 b5fe7000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ff8000 b6016000 r-xp /usr/lib/libsensor.so.1.1.0
b6018000 b609a000 r-xp /usr/lib/libpixman-1.so.0.28.2
b609f000 b60d3000 r-xp /usr/lib/libfontconfig.so.1.5.0
b60d5000 b6130000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6132000 b6148000 r-xp /usr/lib/libfribidi.so.0.3.1
b6149000 b61d5000 r-xp /usr/lib/libfreetype.so.6.11.3
b61d9000 b61dc000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b61dd000 b61e3000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b61e4000 b61ea000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61ec000 b61fd000 r-xp /usr/lib/libXext.so.6.4.0
b61fe000 b6332000 r-xp /usr/lib/libX11.so.6.3.0
b6336000 b633b000 r-xp /usr/lib/libXtst.so.6.1.0
b633c000 b6344000 r-xp /usr/lib/libXrender.so.1.3.0
b6345000 b634e000 r-xp /usr/lib/libXrandr.so.2.2.0
b634f000 b6351000 r-xp /usr/lib/libXinerama.so.1.0.0
b6352000 b6360000 r-xp /usr/lib/libXi.so.6.1.0
b6361000 b6365000 r-xp /usr/lib/libXfixes.so.3.1.0
b6366000 b6368000 r-xp /usr/lib/libXgesture.so.7.0.0
b6369000 b636b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b636c000 b636e000 r-xp /usr/lib/libXdamage.so.1.1.0
b636f000 b6378000 r-xp /usr/lib/libXcursor.so.1.0.2
b6379000 b63a4000 r-xp /usr/lib/libecore_con.so.1.7.99
b63a6000 b63ae000 r-xp /usr/lib/libecore_imf.so.1.7.99
b63af000 b63ba000 r-xp /usr/lib/libethumb_client.so.1.7.99
b63bb000 b63c1000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b63c2000 b63e3000 r-xp /usr/lib/libefreet.so.1.7.99
b63e5000 b63f1000 r-xp /usr/lib/libedbus.so.1.7.99
b63f2000 b6551000 r-xp /usr/lib/libicuuc.so.51.1
b655f000 b6768000 r-xp /usr/lib/libicui18n.so.51.1
b6771000 b680e000 r-xp /usr/lib/libedje.so.1.7.99
b6810000 b6821000 r-xp /usr/lib/libecore_input.so.1.7.99
b6822000 b6829000 r-xp /usr/lib/libecore_file.so.1.7.99
b682a000 b6850000 r-xp /usr/lib/libeet.so.1.7.99
b6859000 b6981000 r-xp /usr/lib/libevas.so.1.7.99
b699e000 b69d1000 r-xp /usr/lib/libecore_evas.so.1.7.99
b69d3000 b6a17000 r-xp /usr/lib/libecore_x.so.1.7.99
b6a19000 b6c13000 r-xp /usr/lib/libelementary.so.1.7.99
b6c24000 b6c2a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6c2b000 b6c2f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6c33000 b6c34000 r-xp /usr/lib/libjournal.so.0.1.0
b6c35000 b6d7d000 r-xp /usr/lib/libxml2.so.2.7.8
b6d84000 b6d97000 r-xp /lib/libresolv-2.13.so
b6d9b000 b6db8000 r-xp /lib/libz.so.1.2.5
b6db9000 b6dbc000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6dbd000 b6dc2000 r-xp /usr/lib/libffi.so.5.0.10
b6dc3000 b6dc4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6dc6000 b6dca000 r-xp /lib/libattr.so.1.1.0
b6dcb000 b6fdd000 r-xp /usr/lib/libcrypto.so.1.0.0
b6ff8000 b7019000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b701a000 b7042000 r-xp /lib/libm-2.13.so
b7044000 b709f000 r-xp /usr/lib/libeina.so.1.7.99
b70a2000 b70ad000 r-xp /usr/lib/libvconf.so.0.2.45
b70ae000 b70b1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b70b2000 b7100000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b7101000 b7262000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b7266000 b726d000 r-xp /lib/librt-2.13.so
b7270000 b7277000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b7279000 b7293000 r-xp /lib/libgcc_s-4.6.4.so.1
b7294000 b729c000 r-xp /lib/libcrypt-2.13.so
b72c5000 b72c9000 r-xp /lib/libcap.so.2.21
b72ca000 b72cc000 r-xp /usr/lib/libiri.so
b72ce000 b72fa000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b72fb000 b731b000 r-xp /usr/lib/libecore.so.1.7.99
b732a000 b7333000 r-xp /usr/lib/libxdgmime.so.1.1.0
b7334000 b7457000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b7458000 b746b000 r-xp /usr/lib/libail.so.0.1.0
b746d000 b7492000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b7493000 b749d000 r-xp /lib/libunwind.so.8.0.1
b74a7000 b7618000 r-xp /lib/libc-2.13.so
b761e000 b7668000 r-xp /usr/lib/libdbus-1.so.3.7.2
b7669000 b766e000 r-xp /usr/lib/libbundle.so.0.1.22
b766f000 b7672000 r-xp /lib/libdl-2.13.so
b7675000 b767a000 r-xp /usr/lib/libsmack.so.1.0.0
b767b000 b7723000 r-xp /usr/lib/libsqlite3.so.0.8.6
b7726000 b7740000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7741000 b7758000 r-xp /lib/libpthread-2.13.so
b775c000 b775f000 r-xp /usr/lib/libdlog.so.0.0.0
b7760000 b7770000 r-xp /usr/lib/libaul.so.0.1.0
b7772000 b7778000 r-xp /usr/lib/libappcore-common.so.1.1
b7779000 b777e000 r-xp /usr/lib/libappcore-efl.so.1.1
b7780000 b7785000 r-xp /usr/lib/libsys-assert.so
b7788000 b77a6000 r-xp /lib/ld-2.13.so
b77a6000 b77a7000 r-xp [vdso]
b77a9000 b77b0000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:4430)
Call Stack Count: 17
 0: __printf_fp + 0x16a0 (0xb74ed3c0) [/lib/libc.so.6] + 0x463c0
 1: _IO_vfprintf + 0x48e5 (0xb74eb345) [/lib/libc.so.6] + 0x44345
 2: vsprintf + 0xa4 (0xb7506d24) [/lib/libc.so.6] + 0x5fd24
 3: (0xb45c1766) [/usr/lib/libcapi-system-sensor.so.0] + 0x3766
 4: (0xb60088b6) [/usr/lib/libsensor.so.1] + 0x108b6
 5: (0xb7377841) [/usr/lib/libglib-2.0.so.0] + 0x43841
 6: g_main_context_dispatch + 0x133 (0xb7379dd3) [/usr/lib/libglib-2.0.so.0] + 0x45dd3
 7: (0xb730fd40) [/usr/lib/libecore.so.1] + 0x14d40
 8: (0xb730896f) [/usr/lib/libecore.so.1] + 0xd96f
 9: (0xb7309654) [/usr/lib/libecore.so.1] + 0xe654
10: ecore_main_loop_begin + 0x3f (0xb73099cf) [/usr/lib/libecore.so.1] + 0xe9cf
11: elm_run + 0x17 (0xb6b208a7) [/usr/lib/libelementary.so.1] + 0x1078a7
12: appcore_efl_main + 0x3d1 (0xb777be91) [/usr/lib/libappcore-efl.so.1] + 0x2e91
13: ui_app_main + 0x130 (0xb6c2d5f0) [/usr/lib/libcapi-appfw-application.so.0] + 0x25f0
14: main + 0x30d (0xb45c63fd) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x13fd
15: (0xb77ac5b1) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0xb77ac5b1
16: __libc_start_main + 0xf3 (0xb74c00f3) [/lib/libc.so.6] + 0x190f3
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
mack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/author-signature.xml, 0, org.example.basicui), result=[0]
03-23 18:42:43.674+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/signature1.xml, 0, org.example.basicui), result=[0]
03-23 18:42:43.674+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/share/packages/org.example.basicui.xml, 0, org.example.basicui), result=[0]
03-23 18:42:43.674+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui, 5, _), result=[0]
03-23 18:42:43.674+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/data, 0, org.example.basicui), result=[0]
03-23 18:42:43.674+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/cache, 0, org.example.basicui), result=[0]
03-23 18:42:43.674+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/shared, 5, _), result=[0]
03-23 18:42:43.694+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/shared/data, 2), result=[0]
03-23 18:42:43.714+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_set_package_version(74) > [smack] app[org.example.basicui] version set to [2.3.1] result=[0]
03-23 18:42:43.714+0900 D/rpm-installer( 4422): coretpk-installer.c: _coretpk_installer_package_install(2330) > api-version fot privilege has done successfully.
03-23 18:42:43.714+0900 D/rpm-installer( 4422): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/appmanager.launch]
03-23 18:42:43.714+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-23 18:42:43.724+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-23 18:42:43.734+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-23 18:42:43.734+0900 D/rpm-installer( 4422): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-23 18:42:43.734+0900 D/rpm-installer( 4422): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/externalstorage]
03-23 18:42:43.744+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-23 18:42:43.744+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-23 18:42:43.754+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-23 18:42:43.754+0900 D/rpm-installer( 4422): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-23 18:42:43.754+0900 D/rpm-installer( 4422): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/externalstorage.appdata]
03-23 18:42:43.764+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-23 18:42:43.764+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-23 18:42:43.784+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-23 18:42:43.784+0900 D/rpm-installer( 4422): rpm-installer.c: __privilege_func(1106) > it is EXT_APPDATA_PRIVILEGE_NAME
03-23 18:42:43.784+0900 D/rpm-installer( 4422): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1390) > Exist shared/data folder (path:[/opt/usr/apps/org.example.basicui/shared/data])
03-23 18:42:43.784+0900 D/rpm-installer( 4422): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-23 18:42:43.784+0900 D/rpm-installer( 4422): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/internet]
03-23 18:42:43.794+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-23 18:42:43.794+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-23 18:42:43.814+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-23 18:42:43.814+0900 D/rpm-installer( 4422): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-23 18:42:43.814+0900 D/rpm-installer( 4422): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/mediastorage]
03-23 18:42:43.814+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-23 18:42:43.814+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-23 18:42:43.834+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-23 18:42:43.834+0900 D/rpm-installer( 4422): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-23 18:42:43.834+0900 D/rpm-installer( 4422): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/network.get]
03-23 18:42:43.834+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-23 18:42:43.844+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-23 18:42:43.854+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-23 18:42:43.854+0900 D/rpm-installer( 4422): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-23 18:42:43.854+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-23 18:42:43.854+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-23 18:42:43.874+0900 D/rpm-installer( 4422): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-23 18:42:43.874+0900 D/rpm-installer( 4422): coretpk-installer.c: _coretpk_installer_package_install(2340) > permission applying done successfully.
03-23 18:42:43.874+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(160) > privilege_manager_verify_privilege called
03-23 18:42:43.874+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/appmanager.launch
03-23 18:42:43.874+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-23 18:42:43.874+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-23 18:42:43.874+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-23 18:42:43.874+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-23 18:42:43.874+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/externalstorage
03-23 18:42:43.874+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-23 18:42:43.874+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/externalstorage.appdata
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/internet
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/mediastorage
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/network.get
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-23 18:42:43.884+0900 D/PRIVILEGE_MANAGER( 4422): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-23 18:42:43.884+0900 D/rpm-installer( 4422): coretpk-installer.c: _coretpk_installer_verify_privilege_list(741) > privilege_manager_verify_privilege_list(PRVMGR_PACKAGE_TYPE_CORE) is ok.
03-23 18:42:43.884+0900 D/rpm-installer( 4422): coretpk-installer.c: _coretpk_installer_package_install(2348) > _coretpk_installer_verify_privilege_list done.
03-23 18:42:43.884+0900 D/rpm-installer( 4422): rpm-vconf-intf.c: _ri_broadcast_status_notification(199) > pkgid=[org.example.basicui], key=[install_percent], val=[100]
03-23 18:42:43.884+0900 D/PKGMGR  ( 2233): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / install_percent / 100
03-23 18:42:43.884+0900 D/PKGMGR  ( 2233): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-23 18:42:43.884+0900 D/PKGMGR  ( 2233): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.884+0900 D/PKGMGR  ( 2233): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.884+0900 D/PKGMGR  ( 2368): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / install_percent / 100
03-23 18:42:43.884+0900 D/PKGMGR  ( 2368): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-23 18:42:43.884+0900 D/PKGMGR  ( 2368): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.884+0900 D/PKGMGR  ( 2368): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.884+0900 D/PKGMGR  ( 2271): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / install_percent / 100
03-23 18:42:43.884+0900 D/PKGMGR  ( 2271): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-23 18:42:43.884+0900 D/DATA_PROVIDER_MASTER( 2271): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.basicui] 100
03-23 18:42:43.884+0900 D/PKGMGR  ( 2271): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.884+0900 D/PKGMGR  ( 2271): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.884+0900 D/PKGMGR  ( 2274): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / install_percent / 100
03-23 18:42:43.884+0900 D/PKGMGR  ( 2274): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-23 18:42:43.884+0900 D/PKGMGR  ( 2274): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.884+0900 D/PKGMGR  ( 2274): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / install_percent / 100
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-23 18:42:43.884+0900 D/ADD_VIEWER( 2241): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.basicui] 100
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / install_percent / 100
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-23 18:42:43.884+0900 D/W_HOME  ( 2241): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.basicui key:install_percent val:100
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / install_percent / 100
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-23 18:42:43.884+0900 D/APPS    ( 2241): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:100] for org.example.basicui
03-23 18:42:43.884+0900 D/APPS    ( 2241): pkgmgr.c: _install_percent(469) >  package(org.example.basicui) with 100
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.884+0900 D/rpm-installer( 4422): coretpk-installer.c: _coretpk_installer_package_install(2370) > install status is [2].
03-23 18:42:43.884+0900 D/rpm-installer( 4422): coretpk-installer.c: __post_install_for_mmc(379) > Installed storage is internal.
03-23 18:42:43.884+0900 D/rpm-installer( 4422): coretpk-installer.c: _coretpk_installer_package_install(2382) > _coretpk_installer_package_install is done.
03-23 18:42:43.884+0900 D/rpm-installer( 4422): rpm-vconf-intf.c: _ri_broadcast_status_notification(207) > pkgid=[org.example.basicui], key=[end], val=[ok]
03-23 18:42:43.884+0900 D/PKGMGR  ( 2233): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / end / ok
03-23 18:42:43.884+0900 D/PKGMGR  ( 2233): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-23 18:42:43.884+0900 D/PKGMGR  ( 2233): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.884+0900 D/PKGMGR  ( 2233): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.884+0900 D/PKGMGR  ( 2368): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / end / ok
03-23 18:42:43.884+0900 D/PKGMGR  ( 2368): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-23 18:42:43.884+0900 D/PKGMGR  ( 2368): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.884+0900 D/PKGMGR  ( 2368): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.884+0900 D/PKGMGR  ( 2271): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / end / ok
03-23 18:42:43.884+0900 D/PKGMGR  ( 2271): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-23 18:42:43.884+0900 D/DATA_PROVIDER_MASTER( 2271): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.basicui] ok
03-23 18:42:43.884+0900 D/PKGMGR  ( 2271): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.884+0900 D/PKGMGR  ( 2271): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.884+0900 D/PKGMGR  ( 2274): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / end / ok
03-23 18:42:43.884+0900 D/PKGMGR  ( 2274): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-23 18:42:43.884+0900 D/PKGMGR  ( 2274): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.884+0900 D/PKGMGR  ( 2274): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / end / ok
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-23 18:42:43.884+0900 D/ADD_VIEWER( 2241): add-viewer_pkgmgr.c: end_cb(420) > [SECURE_LOG] [org.example.basicui] ok
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / end / ok
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-23 18:42:43.884+0900 D/W_HOME  ( 2241): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.basicui key:end val:ok
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / end / ok
03-23 18:42:43.884+0900 D/PKGMGR  ( 2241): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-23 18:42:43.884+0900 D/APPS    ( 2241): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.example.basicui
03-23 18:42:43.884+0900 D/APPS    ( 2241): pkgmgr.c: _end(651) >  Package(org.example.basicui) : key(update) - val(ok)
03-23 18:42:43.884+0900 D/APPS    ( 2241): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.example.basicui]
03-23 18:42:43.884+0900 D/APPS    ( 2241): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.example.basicui]'s item object
03-23 18:42:43.884+0900 D/APPS    ( 2241): db.c: apps_db_remove_item(404) >  Remove the item[org.example.basicui]
03-23 18:42:43.894+0900 D/PKGMGR  ( 2110): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / end / ok
03-23 18:42:43.894+0900 D/PKGMGR  ( 2110): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-23 18:42:43.894+0900 E/PKGMGR_INFO( 2110): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(695) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
03-23 18:42:43.894+0900 D/PKGMGR  ( 2110): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.894+0900 D/PKGMGR  ( 2110): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.894+0900 D/PKGMGR  ( 2167): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492 / coretpk / org.example.basicui / end / ok
03-23 18:42:43.894+0900 D/PKGMGR  ( 2167): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_650600492] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-23 18:42:43.894+0900 D/AUL_AMD ( 2167): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.example.basicui), key(end), value(ok)
03-23 18:42:43.894+0900 D/AUL_AMD ( 2167): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(564) > [SECURE_LOG] op(install), value(ok)
03-23 18:42:43.894+0900 D/AUL_AMD ( 2167): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
03-23 18:42:43.894+0900 D/AUL_AMD ( 2167): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.example.basicui, comp:ui, type:rpm
03-23 18:42:43.894+0900 D/PKGMGR  ( 2167): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.894+0900 D/PKGMGR  ( 2167): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:43.894+0900 D/rpm-installer( 4422): coretpk-installer.c: _coretpk_installer_prepare_package_install(2872) > success
03-23 18:42:43.894+0900 D/rpm-installer( 4422): rpm-appcore-intf.c: main(224) > sync() start
03-23 18:42:43.914+0900 D/APPS    ( 2241): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.basicui], name[basicui]
03-23 18:42:43.914+0900 D/APPS    ( 2241): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.basicui]
03-23 18:42:43.914+0900 D/DATA_PROVIDER_MASTER( 2271): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [51]
03-23 18:42:43.914+0900 D/DATA_PROVIDER_MASTER( 2271): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-23 18:42:43.914+0900 D/BADGE   ( 2271): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-23 18:42:43.914+0900 D/DATA_PROVIDER_MASTER( 2271): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-23 18:42:43.914+0900 E/DATA_PROVIDER_MASTER( 2271): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-23 18:42:43.914+0900 D/COM_CORE( 2241): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2271, fd: -1
03-23 18:42:43.914+0900 D/COM_CORE( 2241): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2271), fd: -1
03-23 18:42:43.914+0900 D/COM_CORE( 2241): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 43 (recv_fd: -1)
03-23 18:42:43.914+0900 D/APPS    ( 2241): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.basicui]
03-23 18:42:43.914+0900 D/DATA_PROVIDER_MASTER( 2271): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [54]
03-23 18:42:43.914+0900 D/DATA_PROVIDER_MASTER( 2271): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
03-23 18:42:43.924+0900 D/rpm-installer( 4422): rpm-appcore-intf.c: main(226) > sync() end
03-23 18:42:43.924+0900 D/rpm-installer( 4422): rpm-appcore-intf.c: main(245) > ------------------------------------------------
03-23 18:42:43.924+0900 D/rpm-installer( 4422): rpm-appcore-intf.c: main(246) >  [END] rpm-installer: result=[0]
03-23 18:42:43.924+0900 D/rpm-installer( 4422): rpm-appcore-intf.c: main(247) > ------------------------------------------------
03-23 18:42:43.924+0900 D/PKGMGR_SERVER( 4413): pkgmgr-server.c: sighandler(326) > child exit [4422]
03-23 18:42:43.924+0900 D/PKGMGR_SERVER( 4413): pkgmgr-server.c: sighandler(341) > child NORMAL exit [4422]
03-23 18:42:43.924+0900 D/COM_CORE( 2271): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-23 18:42:43.924+0900 D/DATA_PROVIDER_MASTER( 2271): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8281508 is terminated (NIL packet)
03-23 18:42:43.924+0900 D/DATA_PROVIDER_MASTER( 2271): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-23 18:42:43.924+0900 D/DATA_PROVIDER_MASTER( 2271): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-23 18:42:43.924+0900 D/BADGE   ( 2271): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-23 18:42:43.924+0900 D/DATA_PROVIDER_MASTER( 2271): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-23 18:42:43.924+0900 E/DATA_PROVIDER_MASTER( 2271): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-23 18:42:43.934+0900 D/COM_CORE( 2241): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2271, fd: -1
03-23 18:42:43.934+0900 D/COM_CORE( 2241): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2271), fd: -1
03-23 18:42:43.934+0900 D/COM_CORE( 2241): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 43 (recv_fd: -1)
03-23 18:42:43.934+0900 D/APPS    ( 2241): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.basicui], name[basicui]
03-23 18:42:43.934+0900 D/APPS    ( 2241): item.c: item_create(819) >  Icon size after ea_effect (124:127)
03-23 18:42:43.934+0900 D/BADGE   ( 2241): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-23 18:42:43.934+0900 D/APPS    ( 2241): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
03-23 18:42:43.934+0900 D/APPS    ( 2241): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.basicui]'s ordering : 1
03-23 18:42:43.934+0900 D/APPS    ( 2241): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
03-23 18:42:43.944+0900 D/DATA_PROVIDER_MASTER( 2271): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
03-23 18:42:43.944+0900 D/COM_CORE( 2271): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-23 18:42:43.944+0900 D/DATA_PROVIDER_MASTER( 2271): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb827f7e0 is terminated (NIL packet)
03-23 18:42:43.944+0900 D/DATA_PROVIDER_MASTER( 2271): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-23 18:42:43.954+0900 D/APPS    ( 2241): db.c: apps_db_insert_item(345) >  Insert the item[org.example.basicui:1]
03-23 18:42:43.964+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-23 18:42:43.964+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-23 18:42:44.204+0900 I/GESTURE ( 2052): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-23 18:42:44.254+0900 D/EFL     ( 2241): ecore_x<2241> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=23515215 button=1
03-23 18:42:44.254+0900 D/APPS    ( 2241): scroller.c: _mouse_down_cb(100) >  Mouse is down [170,232]
03-23 18:42:44.254+0900 D/APPS    ( 2241): item.c: _down_cb(381) >  Down (basicui,0xb7b8e680) (170, 232), item pos(41,1,280,390)
03-23 18:42:44.254+0900 E/APPS    ( 2241): item.c: _down_cb(425) >  longpress edit mode disable
03-23 18:42:44.254+0900 W/APPS    ( 2241): item.c: _anim_item_pressed_cb(1046) >  item is pressed
03-23 18:42:44.324+0900 D/EFL     ( 2241): ecore_x<2241> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=23515332 button=1
03-23 18:42:44.324+0900 D/APPS    ( 2241): scroller.c: _mouse_up_cb(111) >  Mouse is up [170,232]
03-23 18:42:44.324+0900 D/APPS    ( 2241): item.c: _up_cb(573) >  Up (basicui,0xb7b8e680) (170, 232), item pos(41,1,280,390)
03-23 18:42:44.324+0900 E/APPS    ( 2241): item.c: _clicked_cb(65) >  Clicked
03-23 18:42:44.324+0900 E/APPS    ( 2241): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-23 18:42:44.324+0900 D/APPS    ( 2241): item.c: _clicked_cb(95) >  item(rpm) launched to aul_launch
03-23 18:42:44.324+0900 D/APP_SVC ( 2241): appsvc.c: __set_bundle(161) > __set_bundle
03-23 18:42:44.324+0900 D/APP_SVC ( 2241): appsvc.c: __get_alias_appid(568) > [SECURE_LOG] alias_id : (null)
03-23 18:42:44.324+0900 D/APP_SVC ( 2241): appsvc.c: __set_bundle(161) > __set_bundle
03-23 18:42:44.324+0900 D/W_HOME  ( 2241): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
03-23 18:42:44.324+0900 D/W_HOME  ( 2241): dbus_util.c: home_dbus_cpu_booster_signal_send(278) > Sending cpu booster call:200 result:0
03-23 18:42:44.324+0900 D/APP_SVC ( 2241): appsvc.c: __run_svc_with_pkgname(237) > [SECURE_LOG] pkg_name : org.example.basicui - no result
03-23 18:42:44.324+0900 D/AUL     ( 2241): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.example.basicui
03-23 18:42:44.324+0900 D/AUL     ( 2241): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
03-23 18:42:44.324+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(495) > __request_handler: 0
03-23 18:42:44.324+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-23 18:42:44.324+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : org.tizen.w-home
03-23 18:42:44.324+0900 E/AUL_AMD ( 2167): amd_launch.c: invoke_dbus_method_sync(1190) > dbus_connection_send error(org.freedesktop.DBus.Error.ServiceUnknown:The name org.tizen.system.coord was not provided by any .service files)
03-23 18:42:44.324+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1690) > org.tizen.system.coord.rotation-Degree : -74
03-23 18:42:44.324+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1785) > process_pool: false
03-23 18:42:44.324+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-23 18:42:44.324+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.basicui
03-23 18:42:44.324+0900 D/AUL_AMD ( 2167): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-23 18:42:44.324+0900 D/AUL     ( 2167): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-23 18:42:44.324+0900 D/AUL_PAD ( 2189): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
03-23 18:42:44.324+0900 D/AUL_PAD ( 2189): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-23 18:42:44.324+0900 D/AUL_PAD ( 2189): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 4430 /opt/usr/apps/org.example.basicui/bin/basicui
03-23 18:42:44.324+0900 D/AUL_PAD ( 2189): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-23 18:42:44.334+0900 D/AUL_PAD ( 4430): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-23 18:42:44.334+0900 D/AUL_PAD ( 4430): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-23 18:42:44.334+0900 D/AUL_PAD ( 4430): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
03-23 18:42:44.334+0900 D/AUL_PAD ( 4430): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-23 18:42:44.334+0900 D/AUL_PAD ( 4430): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
03-23 18:42:44.334+0900 D/AUL_PAD ( 4430): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
03-23 18:42:44.334+0900 D/AUL_PAD ( 4430): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
03-23 18:42:44.334+0900 D/AUL_PAD ( 4430): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
03-23 18:42:44.334+0900 D/AUL_PAD ( 4430): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
03-23 18:42:44.334+0900 D/AUL_PAD ( 4430): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
03-23 18:42:44.334+0900 D/LAUNCH  ( 4430): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
03-23 18:42:44.344+0900 I/efl-extension( 4430): efl_extension.c: eext_mod_init(39) > Init
03-23 18:42:44.344+0900 I/CAPI_APPFW_APPLICATION( 4430): app_main.c: ui_app_main(701) > app_efl_main
03-23 18:42:44.344+0900 D/LAUNCH  ( 4430): appcore-efl.c: appcore_efl_main(1571) > [basicui:Application:main:done]
03-23 18:42:44.364+0900 D/APP_CORE( 4430): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-23 18:42:44.374+0900 D/AUL     ( 4430): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 4430 is org.example.basicui
03-23 18:42:44.374+0900 D/APP_CORE( 4430): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.basicui/res/locale
03-23 18:42:44.374+0900 D/APP_CORE( 4430): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-23 18:42:44.374+0900 D/AUL     ( 4430): app_sock.c: __create_server_sock(136) > pg path - already exists
03-23 18:42:44.374+0900 D/LAUNCH  ( 4430): appcore-efl.c: __before_loop(1035) > [basicui:Platform:appcore_init:done]
03-23 18:42:44.374+0900 I/CAPI_APPFW_APPLICATION( 4430): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-23 18:42:44.394+0900 E/EFL     ( 4430): eina_module<4430> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-23 18:42:44.404+0900 E/EFL     ( 4430): ecore_evas<4430> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-23 18:42:44.404+0900 E/EFL     ( 4430): elementary<4430> elc_naviframe.c:46 _nf_mod_init() _nf_mod_init initted 1
03-23 18:42:44.404+0900 E/EFL     ( 4430): eina_module<4430> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so", RTLD_NOW): /opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so: cannot open shared object file: No such file or directory
03-23 18:42:44.414+0900 I/basicui ( 4430): started
03-23 18:42:44.414+0900 I/basicui ( 4430): listener
03-23 18:42:44.414+0900 D/LAUNCH  ( 4430): appcore-efl.c: __before_loop(1047) > [basicui:Application:create:done]
03-23 18:42:44.414+0900 D/APP_CORE( 4430): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
03-23 18:42:44.414+0900 D/APP_CORE( 4430): appcore.c: __aul_handler(423) > [APP 4430]     AUL event: AUL_START
03-23 18:42:44.414+0900 D/APP_CORE( 4430): appcore-efl.c: __do_app(470) > [APP 4430] Event: RESET State: CREATED
03-23 18:42:44.414+0900 D/APP_CORE( 4430): appcore-efl.c: __do_app(496) > [APP 4430] RESET
03-23 18:42:44.414+0900 D/LAUNCH  ( 4430): appcore-efl.c: __do_app(498) > [basicui:Application:reset:start]
03-23 18:42:44.414+0900 I/CAPI_APPFW_APPLICATION( 4430): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
03-23 18:42:44.414+0900 D/LAUNCH  ( 4430): appcore-efl.c: __do_app(501) > [basicui:Application:reset:done]
03-23 18:42:44.424+0900 I/APP_CORE( 4430): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
03-23 18:42:44.424+0900 I/APP_CORE( 4430): appcore-efl.c: __do_app(509) > [APP 4430] Initial Launching, call the resume_cb
03-23 18:42:44.424+0900 I/CAPI_APPFW_APPLICATION( 4430): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
03-23 18:42:44.424+0900 D/APP_CORE( 4430): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : org.tizen.w-home
03-23 18:42:44.424+0900 D/AUL_PAD ( 2189): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-23 18:42:44.424+0900 D/AUL_PAD ( 2189): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-23 18:42:44.424+0900 D/AUL_PAD ( 2189): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-23 18:42:44.424+0900 D/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-23 18:42:44.424+0900 E/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(264) > access
03-23 18:42:44.424+0900 D/RESOURCED( 2337): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-23 18:42:44.424+0900 D/RESOURCED( 2337): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2167
03-23 18:42:44.424+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.basicui, pid 4430, type 4 
03-23 18:42:44.424+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.basicui, 4430
03-23 18:42:44.424+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.basicui with pkgname
03-23 18:42:44.424+0900 E/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 248
03-23 18:42:44.424+0900 D/RESOURCED( 2337): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-23 18:42:44.424+0900 D/AUL     ( 2241): launch.c: app_request_to_launchpad(295) > launch request result : 4430
03-23 18:42:44.424+0900 D/W_HOME  ( 2241): util.c: apps_util_launch_main_operation(686) > [SECURE_LOG] Launch an app(org.example.basicui:basicui) ret : [0]
03-23 18:42:44.424+0900 D/LAUNCH  ( 2241): util.c: apps_util_launch_main_operation(687) > [SECURE_LOG] [org.example.basicui:Menuscreen:launch:done]
03-23 18:42:44.434+0900 E/W_HOME  ( 2241): main.c: _window_focus_out_cb(885) > win[25165827], ev->win[25165831]
03-23 18:42:44.434+0900 D/APPS    ( 2241): apps_main.c: _window_focus_out_cb(308) >  focus out
03-23 18:42:44.434+0900 E/W_HOME  ( 2241): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
03-23 18:42:44.434+0900 D/APPS    ( 2241): apps_main.c: apps_main_pause(656) >  Pause starts
03-23 18:42:44.434+0900 D/APPS    ( 2241): apps_main.c: apps_main_pause(676) >  Pause done
03-23 18:42:44.444+0900 W/APPS    ( 2241): item.c: _anim_item_released_cb(1075) >  item is released
03-23 18:42:44.444+0900 D/APPS    ( 2241): item.c: _anim_move_item_to_empty_position(156) >  item_inner was not unset
03-23 18:42:44.454+0900 D/APP_CORE( 4430): appcore.c: __prt_ltime(183) > [APP 4430] first idle after reset: 136 msec
03-23 18:42:44.454+0900 D/APP_CORE( 4430): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00002
03-23 18:42:44.454+0900 D/APP_CORE( 4430): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00002
03-23 18:42:44.534+0900 D/APP_CORE( 2241): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1800007 fully_obscured 1
03-23 18:42:44.534+0900 D/APP_CORE( 2241): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
03-23 18:42:44.534+0900 D/APP_CORE( 2241): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
03-23 18:42:44.534+0900 D/APP_CORE( 2241): appcore-efl.c: __do_app(470) > [APP 2241] Event: PAUSE State: PAUSED
03-23 18:42:44.534+0900 D/APP_CORE( 2241): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-23 18:42:44.534+0900 E/APP_CORE( 2241): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-23 18:42:44.534+0900 D/RESOURCED( 2337): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2241, type = 2
03-23 18:42:44.544+0900 D/APP_CORE( 4430): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1c00002 fully_obscured 0
03-23 18:42:44.544+0900 D/APP_CORE( 4430): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
03-23 18:42:44.544+0900 D/APP_CORE( 4430): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-23 18:42:44.544+0900 D/APP_CORE( 4430): appcore-efl.c: __do_app(470) > [APP 4430] Event: RESUME State: RUNNING
03-23 18:42:44.544+0900 D/LAUNCH  ( 4430): appcore-efl.c: __do_app(557) > [basicui:Application:resume:start]
03-23 18:42:44.544+0900 D/LAUNCH  ( 4430): appcore-efl.c: __do_app(567) > [basicui:Application:resume:done]
03-23 18:42:44.544+0900 D/LAUNCH  ( 4430): appcore-efl.c: __do_app(569) > [basicui:Application:Launching:done]
03-23 18:42:44.544+0900 D/APP_CORE( 4430): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-23 18:42:44.544+0900 E/APP_CORE( 4430): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-23 18:42:44.544+0900 D/AUL_AMD ( 2167): amd_launch.c: __e17_status_handler(1911) > pid(4430) status(3)
03-23 18:42:44.544+0900 D/RESOURCED( 2337): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 4430, type = 0
03-23 18:42:44.544+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 4430
03-23 18:42:44.544+0900 I/RESOURCED( 2337): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 4430, oom : 200
03-23 18:42:44.544+0900 E/RESOURCED( 2337): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
03-23 18:42:44.994+0900 D/PKGMGR_SERVER( 4413): pkgmgr-server.c: exit_server(724) > exit_server Start
03-23 18:42:44.994+0900 D/PKGMGR_SERVER( 4413): pkgmgr-server.c: main(1516) > Quit main loop.
03-23 18:42:44.994+0900 D/PKGMGR_SERVER( 4413): pkgmgr-server.c: main(1524) > package manager server terminated.
03-23 18:42:45.374+0900 D/AUL_AMD ( 2167): amd_status.c: __app_terminate_timer_cb(113) > pid(4368)
03-23 18:42:45.374+0900 D/AUL_AMD ( 2167): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
03-23 18:42:45.384+0900 W/CRASH_MANAGER( 4336): worker.c: worker_job(1189) > 1104430626173145872616