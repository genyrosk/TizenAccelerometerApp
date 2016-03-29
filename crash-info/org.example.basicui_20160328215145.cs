S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:37

Crash Information
Process Name: basicui
PID: 3860
Date: 2016-03-28 21:51:45+0900
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2e353499

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x2e35342d, esi = 0xb454765f
ebp = 0xbfe076d8, esp = 0xbfe07610
eax = 0xb927b3b0, ebx = 0xb4548bac
ecx = 0xb4548bac, edx = 0xb454765b
eip = 0xb45472ca

Memory Information
MemTotal:      124 KB
MemFree:        60 KB
Buffers:         2 KB
Cached:     138444 KB
VmPeak:      71944 KB
VmSize:      71944 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14392 KB
VmRSS:       14392 KB
VmData:      11592 KB
VmStk:         992 KB
VmExe:          28 KB
VmLib:       31800 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3860 TID = 3860
3860 3864 

Maps Information
b3527000 b3528000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b3529000 b352b000 r-xp /usr/lib/elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so
b352c000 b3550000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b36f2000 b36f5000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b36f6000 b3704000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b3705000 b3714000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b3f1b000 b3f1e000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3f1f000 b3f22000 r-xp /usr/lib/libdri2.so.0.0.0
b3f23000 b3f2e000 r-xp /usr/lib/libdrm.so.2.4.0
b3f2f000 b3f38000 r-xp /usr/lib/libtbm.so.1.0.0
b3f39000 b3f40000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3f41000 b3f4a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3f4b000 b3f52000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3f53000 b3f59000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3f5a000 b3f62000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3f63000 b3f67000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b3f68000 b3f85000 r-xp /usr/lib/libtts.so
b3f86000 b40ca000 r-xp /usr/lib/libcairo.so.2.11200.14
b40ce000 b40e6000 r-xp /usr/lib/libefl-assist.so.0.1.0
b40e7000 b4108000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4109000 b4119000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b411a000 b4125000 r-xp /lib/libnss_files-2.13.so
b4366000 b438d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b438e000 b43b3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b43b4000 b44d5000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b44e5000 b451b000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b451d000 b4520000 r-xp /usr/lib/libiniparser.so.0
b4522000 b452c000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b452d000 b4536000 r-xp /usr/lib/libappsvc.so.0.1.0
b4537000 b453a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b453b000 b453d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b453e000 b4544000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b4545000 b4548000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
b4549000 b454f000 r-xp /usr/lib/libogg.so.0.7.1
b4550000 b457b000 r-xp /usr/lib/libvorbis.so.0.4.3
b457c000 b4667000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4675000 b4677000 r-xp /usr/lib/libXau.so.6.0.0
b4678000 b46d8000 r-xp /usr/lib/libssl.so.1.0.0
b46dd000 b470e000 r-xp /usr/lib/libidn.so.11.5.44
b470f000 b471f000 r-xp /usr/lib/libcares.so.2.1.0
b4720000 b4789000 r-xp /usr/lib/libsndfile.so.1.0.25
b478f000 b4799000 r-xp /usr/lib/libsensord-share.so
b479a000 b47c0000 r-xp /lib/libexpat.so.1.5.2
b47c2000 b47e9000 r-xp /usr/lib/libpng12.so.0.50.0
b47ea000 b480a000 r-xp /usr/lib/libxcb.so.1.1.0
b480b000 b487a000 r-xp /usr/lib/libcurl.so.4.3.0
b487c000 b4887000 r-xp /usr/lib/libethumb.so.1.7.99
b5de7000 b5ebf000 r-xp /usr/lib/libstdc++.so.6.0.16
b5ecb000 b5ece000 r-xp /usr/lib/libctxdata.so.0.0.0
b5ecf000 b5ee5000 r-xp /usr/lib/libremix.so.0.0.0
b5ee6000 b5ee8000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5ee9000 b5f15000 r-xp /usr/lib/liblua-5.1.so
b5f16000 b5f20000 r-xp /usr/lib/libembryo.so.1.7.99
b5f21000 b5f67000 r-xp /usr/lib/libjpeg.so.8.0.2
b5f78000 b5f96000 r-xp /usr/lib/libsensor.so.1.1.0
b5f98000 b601a000 r-xp /usr/lib/libpixman-1.so.0.28.2
b601f000 b6053000 r-xp /usr/lib/libfontconfig.so.1.5.0
b6055000 b60b0000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b60b2000 b60c8000 r-xp /usr/lib/libfribidi.so.0.3.1
b60c9000 b6155000 r-xp /usr/lib/libfreetype.so.6.11.3
b6159000 b615c000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b615d000 b6163000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6164000 b616a000 r-xp /usr/lib/libecore_fb.so.1.7.99
b616c000 b617d000 r-xp /usr/lib/libXext.so.6.4.0
b617e000 b62b2000 r-xp /usr/lib/libX11.so.6.3.0
b62b6000 b62bb000 r-xp /usr/lib/libXtst.so.6.1.0
b62bc000 b62c4000 r-xp /usr/lib/libXrender.so.1.3.0
b62c5000 b62ce000 r-xp /usr/lib/libXrandr.so.2.2.0
b62cf000 b62d1000 r-xp /usr/lib/libXinerama.so.1.0.0
b62d2000 b62e0000 r-xp /usr/lib/libXi.so.6.1.0
b62e1000 b62e5000 r-xp /usr/lib/libXfixes.so.3.1.0
b62e6000 b62e8000 r-xp /usr/lib/libXgesture.so.7.0.0
b62e9000 b62eb000 r-xp /usr/lib/libXcomposite.so.1.0.0
b62ec000 b62ee000 r-xp /usr/lib/libXdamage.so.1.1.0
b62ef000 b62f8000 r-xp /usr/lib/libXcursor.so.1.0.2
b62f9000 b6324000 r-xp /usr/lib/libecore_con.so.1.7.99
b6326000 b632e000 r-xp /usr/lib/libecore_imf.so.1.7.99
b632f000 b633a000 r-xp /usr/lib/libethumb_client.so.1.7.99
b633b000 b6341000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6342000 b6363000 r-xp /usr/lib/libefreet.so.1.7.99
b6365000 b6371000 r-xp /usr/lib/libedbus.so.1.7.99
b6372000 b64d1000 r-xp /usr/lib/libicuuc.so.51.1
b64df000 b66e8000 r-xp /usr/lib/libicui18n.so.51.1
b66f1000 b678e000 r-xp /usr/lib/libedje.so.1.7.99
b6790000 b67a1000 r-xp /usr/lib/libecore_input.so.1.7.99
b67a2000 b67a9000 r-xp /usr/lib/libecore_file.so.1.7.99
b67aa000 b67d0000 r-xp /usr/lib/libeet.so.1.7.99
b67d9000 b6901000 r-xp /usr/lib/libevas.so.1.7.99
b691e000 b6951000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6953000 b6997000 r-xp /usr/lib/libecore_x.so.1.7.99
b6999000 b6b93000 r-xp /usr/lib/libelementary.so.1.7.99
b6ba4000 b6baa000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6bab000 b6baf000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6bb3000 b6bb4000 r-xp /usr/lib/libjournal.so.0.1.0
b6bb5000 b6cfd000 r-xp /usr/lib/libxml2.so.2.7.8
b6d04000 b6d17000 r-xp /lib/libresolv-2.13.so
b6d1b000 b6d38000 r-xp /lib/libz.so.1.2.5
b6d39000 b6d3c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d3d000 b6d42000 r-xp /usr/lib/libffi.so.5.0.10
b6d43000 b6d44000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d46000 b6d4a000 r-xp /lib/libattr.so.1.1.0
b6d4b000 b6f5d000 r-xp /usr/lib/libcrypto.so.1.0.0
b6f78000 b6f99000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6f9a000 b6fc2000 r-xp /lib/libm-2.13.so
b6fc4000 b701f000 r-xp /usr/lib/libeina.so.1.7.99
b7022000 b702d000 r-xp /usr/lib/libvconf.so.0.2.45
b702e000 b7031000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b7032000 b7080000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b7081000 b71e2000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b71e6000 b71ed000 r-xp /lib/librt-2.13.so
b71f0000 b71f7000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b71f9000 b7213000 r-xp /lib/libgcc_s-4.6.4.so.1
b7214000 b721c000 r-xp /lib/libcrypt-2.13.so
b7245000 b7249000 r-xp /lib/libcap.so.2.21
b724a000 b724c000 r-xp /usr/lib/libiri.so
b724e000 b727a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b727b000 b729b000 r-xp /usr/lib/libecore.so.1.7.99
b72aa000 b72b3000 r-xp /usr/lib/libxdgmime.so.1.1.0
b72b4000 b73d7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b73d8000 b73eb000 r-xp /usr/lib/libail.so.0.1.0
b73ed000 b7412000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b7413000 b741d000 r-xp /lib/libunwind.so.8.0.1
b7427000 b7598000 r-xp /lib/libc-2.13.so
b759e000 b75e8000 r-xp /usr/lib/libdbus-1.so.3.7.2
b75e9000 b75ee000 r-xp /usr/lib/libbundle.so.0.1.22
b75ef000 b75f2000 r-xp /lib/libdl-2.13.so
b75f5000 b75fa000 r-xp /usr/lib/libsmack.so.1.0.0
b75fb000 b76a3000 r-xp /usr/lib/libsqlite3.so.0.8.6
b76a6000 b76c0000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76c1000 b76d8000 r-xp /lib/libpthread-2.13.so
b76dc000 b76df000 r-xp /usr/lib/libdlog.so.0.0.0
b76e0000 b76f0000 r-xp /usr/lib/libaul.so.0.1.0
b76f2000 b76f8000 r-xp /usr/lib/libappcore-common.so.1.1
b76f9000 b76fe000 r-xp /usr/lib/libappcore-efl.so.1.1
b7700000 b7705000 r-xp /usr/lib/libsys-assert.so
b7708000 b7726000 r-xp /lib/ld-2.13.so
b7726000 b7727000 r-xp [vdso]
b7729000 b7730000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:3860)
Call Stack Count: 8
 0: save_data + 0x15a (0xb45472ca) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x22ca
 1: app_create + 0x81 (0xb45466a1) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x16a1
 2: (0xb6bac3cf) [/usr/lib/libcapi-appfw-application.so.0] + 0x13cf
 3: appcore_efl_main + 0x293 (0xb76fbd53) [/usr/lib/libappcore-efl.so.1] + 0x2d53
 4: ui_app_main + 0x130 (0xb6bad5f0) [/usr/lib/libcapi-appfw-application.so.0] + 0x25f0
 5: main + 0x337 (0xb45465a7) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x15a7
 6: (0xb772c5b1) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0xb772c5b1
 7: __libc_start_main + 0xf3 (0xb74400f3) [/lib/libc.so.6] + 0x190f3
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
. Exit function
03-28 21:51:39.672+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / install_percent / 60
03-28 21:51:39.672+0900 D/PKGMGR  ( 2248): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-28 21:51:39.672+0900 D/APPS    ( 2248): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:60] for org.example.basicui
03-28 21:51:39.672+0900 D/APPS    ( 2248): pkgmgr.c: _install_percent(469) >  package(org.example.basicui) with 60
03-28 21:51:39.672+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:39.672+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:39.672+0900 D/PKGMGR  ( 2238): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / install_percent / 60
03-28 21:51:39.672+0900 D/PKGMGR  ( 2238): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-28 21:51:39.672+0900 D/PKGMGR  ( 2238): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:39.672+0900 D/PKGMGR  ( 2238): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:39.672+0900 E/PKGMGR_CERT( 3800): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(438) > Transaction Begin
03-28 21:51:39.672+0900 E/PKGMGR_CERT( 3800): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 11 1
03-28 21:51:39.672+0900 E/PKGMGR_CERT( 3800): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 12 1
03-28 21:51:39.672+0900 E/PKGMGR_CERT( 3800): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 13 1
03-28 21:51:39.672+0900 E/PKGMGR_CERT( 3800): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 14 1
03-28 21:51:39.672+0900 E/PKGMGR_CERT( 3800): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 15 1
03-28 21:51:39.672+0900 E/PKGMGR_CERT( 3800): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 16 1
03-28 21:51:39.682+0900 E/PKGMGR_CERT( 3800): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(587) > Transaction Commit and End
03-28 21:51:39.682+0900 E/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_make_directory(1586) > mkdir failed. appdir=[/usr/apps/org.example.basicui/shared], errno=[2][No such file or directory]
03-28 21:51:39.682+0900 E/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1219) > skip! empty dirpath=[/usr/apps/org.example.basicui/shared]
03-28 21:51:39.682+0900 E/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1219) > skip! empty dirpath=[/usr/apps/org.example.basicui/shared/res]
03-28 21:51:39.682+0900 E/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.basicui/tizen-manifest.xml]
03-28 21:51:39.682+0900 E/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.basicui/author-signature.xml]
03-28 21:51:39.682+0900 E/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.basicui/signature1.xml]
03-28 21:51:39.682+0900 E/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/share/packages/org.example.basicui.xml]
03-28 21:51:39.682+0900 D/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1390) > Exist shared/data folder (path:[/opt/usr/apps/org.example.basicui/shared/data])
03-28 21:51:39.702+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_register_package(64) > [smack] app_install(org.example.basicui), result=[0]
03-28 21:51:39.702+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui, 5, _), result=[0]
03-28 21:51:39.702+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared, 5, _), result=[0]
03-28 21:51:39.702+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared/res, 5, _), result=[0]
03-28 21:51:39.732+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared/data, 2), result=[0]
03-28 21:51:39.732+0900 D/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_get_group_id(1866) > encoding done, len=[28]
03-28 21:51:39.732+0900 D/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_apply_smack(1974) > groupid = [682QedHw7g5Hf0gJXcIO5I3Okls=] for shared/trusted.
03-28 21:51:39.772+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared/trusted, 1, 682QedHw7g5Hf0gJXcIO5I3Okls=), result=[0]
03-28 21:51:39.772+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/bin, 0, org.example.basicui), result=[0]
03-28 21:51:39.772+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/data, 0, org.example.basicui), result=[0]
03-28 21:51:39.772+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/lib, 0, org.example.basicui), result=[0]
03-28 21:51:39.772+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/res, 0, org.example.basicui), result=[0]
03-28 21:51:39.772+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/cache, 0, org.example.basicui), result=[0]
03-28 21:51:39.772+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/tizen-manifest.xml, 0, org.example.basicui), result=[0]
03-28 21:51:39.772+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/author-signature.xml, 0, org.example.basicui), result=[0]
03-28 21:51:39.772+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/signature1.xml, 0, org.example.basicui), result=[0]
03-28 21:51:39.772+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/share/packages/org.example.basicui.xml, 0, org.example.basicui), result=[0]
03-28 21:51:39.772+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui, 5, _), result=[0]
03-28 21:51:39.772+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/data, 0, org.example.basicui), result=[0]
03-28 21:51:39.772+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/cache, 0, org.example.basicui), result=[0]
03-28 21:51:39.772+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/shared, 5, _), result=[0]
03-28 21:51:39.782+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/shared/data, 2), result=[0]
03-28 21:51:39.812+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_set_package_version(74) > [smack] app[org.example.basicui] version set to [2.3.1] result=[0]
03-28 21:51:39.812+0900 D/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_package_install(2330) > api-version fot privilege has done successfully.
03-28 21:51:39.812+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/appmanager.launch]
03-28 21:51:39.812+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-28 21:51:39.812+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-28 21:51:39.862+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-28 21:51:39.862+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-28 21:51:39.862+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/content.write]
03-28 21:51:39.862+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-28 21:51:39.862+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-28 21:51:39.872+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-28 21:51:39.872+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-28 21:51:39.872+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/externalstorage]
03-28 21:51:39.912+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-28 21:51:39.912+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-28 21:51:39.922+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-28 21:51:39.922+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-28 21:51:39.922+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/externalstorage.appdata]
03-28 21:51:39.922+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-28 21:51:39.922+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-28 21:51:39.962+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-28 21:51:39.962+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1106) > it is EXT_APPDATA_PRIVILEGE_NAME
03-28 21:51:39.962+0900 D/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1390) > Exist shared/data folder (path:[/opt/usr/apps/org.example.basicui/shared/data])
03-28 21:51:39.962+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-28 21:51:39.962+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/internet]
03-28 21:51:39.962+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-28 21:51:39.962+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-28 21:51:39.982+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-28 21:51:39.982+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-28 21:51:39.982+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/mediastorage]
03-28 21:51:40.002+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-28 21:51:40.002+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-28 21:51:40.022+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-28 21:51:40.022+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-28 21:51:40.022+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/network.get]
03-28 21:51:40.022+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-28 21:51:40.022+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-28 21:51:40.032+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-28 21:51:40.032+0900 D/rpm-installer( 3800): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-28 21:51:40.052+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-28 21:51:40.052+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-28 21:51:40.062+0900 D/rpm-installer( 3800): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-28 21:51:40.062+0900 D/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_package_install(2340) > permission applying done successfully.
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(160) > privilege_manager_verify_privilege called
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/appmanager.launch
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/content.write
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/externalstorage
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/externalstorage.appdata
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/internet
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/mediastorage
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/network.get
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-28 21:51:40.062+0900 D/PRIVILEGE_MANAGER( 3800): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-28 21:51:40.062+0900 D/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_verify_privilege_list(741) > privilege_manager_verify_privilege_list(PRVMGR_PACKAGE_TYPE_CORE) is ok.
03-28 21:51:40.062+0900 D/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_package_install(2348) > _coretpk_installer_verify_privilege_list done.
03-28 21:51:40.062+0900 D/rpm-installer( 3800): rpm-vconf-intf.c: _ri_broadcast_status_notification(199) > pkgid=[org.example.basicui], key=[install_percent], val=[100]
03-28 21:51:40.062+0900 D/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_package_install(2370) > install status is [2].
03-28 21:51:40.062+0900 D/rpm-installer( 3800): coretpk-installer.c: __post_install_for_mmc(379) > Installed storage is internal.
03-28 21:51:40.062+0900 D/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_package_install(2382) > _coretpk_installer_package_install is done.
03-28 21:51:40.062+0900 D/rpm-installer( 3800): rpm-vconf-intf.c: _ri_broadcast_status_notification(207) > pkgid=[org.example.basicui], key=[end], val=[ok]
03-28 21:51:40.062+0900 D/rpm-installer( 3800): coretpk-installer.c: _coretpk_installer_prepare_package_install(2872) > success
03-28 21:51:40.062+0900 D/rpm-installer( 3800): rpm-appcore-intf.c: main(224) > sync() start
03-28 21:51:40.072+0900 D/PKGMGR  ( 2368): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / install_percent / 100
03-28 21:51:40.072+0900 D/PKGMGR  ( 2368): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-28 21:51:40.072+0900 D/PKGMGR  ( 2368): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.072+0900 D/PKGMGR  ( 2368): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.072+0900 D/PKGMGR  ( 2368): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / end / ok
03-28 21:51:40.072+0900 D/PKGMGR  ( 2368): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-28 21:51:40.072+0900 D/PKGMGR  ( 2368): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.072+0900 D/PKGMGR  ( 2368): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.072+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / install_percent / 100
03-28 21:51:40.072+0900 D/PKGMGR  ( 2273): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-28 21:51:40.072+0900 D/DATA_PROVIDER_MASTER( 2273): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.basicui] 100
03-28 21:51:40.072+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.072+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.072+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / end / ok
03-28 21:51:40.072+0900 D/PKGMGR  ( 2273): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-28 21:51:40.072+0900 D/DATA_PROVIDER_MASTER( 2273): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.basicui] ok
03-28 21:51:40.072+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.072+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / install_percent / 100
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-28 21:51:40.072+0900 D/ADD_VIEWER( 2248): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.basicui] 100
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / install_percent / 100
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-28 21:51:40.072+0900 D/W_HOME  ( 2248): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.basicui key:install_percent val:100
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / install_percent / 100
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-28 21:51:40.072+0900 D/APPS    ( 2248): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:100] for org.example.basicui
03-28 21:51:40.072+0900 D/APPS    ( 2248): pkgmgr.c: _install_percent(469) >  package(org.example.basicui) with 100
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / end / ok
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-28 21:51:40.072+0900 D/ADD_VIEWER( 2248): add-viewer_pkgmgr.c: end_cb(420) > [SECURE_LOG] [org.example.basicui] ok
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / end / ok
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-28 21:51:40.072+0900 D/W_HOME  ( 2248): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.basicui key:end val:ok
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / end / ok
03-28 21:51:40.072+0900 D/PKGMGR  ( 2248): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-28 21:51:40.072+0900 D/APPS    ( 2248): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.example.basicui
03-28 21:51:40.072+0900 D/APPS    ( 2248): pkgmgr.c: _end(651) >  Package(org.example.basicui) : key(update) - val(ok)
03-28 21:51:40.072+0900 D/APPS    ( 2248): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.example.basicui]
03-28 21:51:40.072+0900 D/APPS    ( 2248): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.example.basicui]'s item object
03-28 21:51:40.072+0900 D/APPS    ( 2248): db.c: apps_db_remove_item(404) >  Remove the item[org.example.basicui]
03-28 21:51:40.072+0900 D/PKGMGR  ( 2238): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / install_percent / 100
03-28 21:51:40.072+0900 D/PKGMGR  ( 2238): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-28 21:51:40.072+0900 D/PKGMGR  ( 2238): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.072+0900 D/PKGMGR  ( 2238): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.072+0900 D/PKGMGR  ( 2238): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / end / ok
03-28 21:51:40.072+0900 D/PKGMGR  ( 2238): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-28 21:51:40.072+0900 D/PKGMGR  ( 2238): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.072+0900 D/PKGMGR  ( 2238): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.072+0900 D/PKGMGR  ( 2162): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / end / ok
03-28 21:51:40.072+0900 D/PKGMGR  ( 2162): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-28 21:51:40.072+0900 D/AUL_AMD ( 2162): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.example.basicui), key(end), value(ok)
03-28 21:51:40.072+0900 D/AUL_AMD ( 2162): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(564) > [SECURE_LOG] op(install), value(ok)
03-28 21:51:40.072+0900 D/AUL_AMD ( 2162): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
03-28 21:51:40.072+0900 D/AUL_AMD ( 2162): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.example.basicui, comp:ui, type:rpm
03-28 21:51:40.072+0900 D/PKGMGR  ( 2162): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.072+0900 D/PKGMGR  ( 2162): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.072+0900 D/PKGMGR  ( 2110): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / end / ok
03-28 21:51:40.072+0900 D/PKGMGR  ( 2110): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-28 21:51:40.082+0900 D/rpm-installer( 3800): rpm-appcore-intf.c: main(226) > sync() end
03-28 21:51:40.082+0900 D/rpm-installer( 3800): rpm-appcore-intf.c: main(245) > ------------------------------------------------
03-28 21:51:40.082+0900 D/rpm-installer( 3800): rpm-appcore-intf.c: main(246) >  [END] rpm-installer: result=[0]
03-28 21:51:40.082+0900 D/rpm-installer( 3800): rpm-appcore-intf.c: main(247) > ------------------------------------------------
03-28 21:51:40.082+0900 D/PKGMGR_SERVER( 3791): pkgmgr-server.c: sighandler(326) > child exit [3800]
03-28 21:51:40.082+0900 D/PKGMGR_SERVER( 3791): pkgmgr-server.c: sighandler(341) > child NORMAL exit [3800]
03-28 21:51:40.092+0900 D/APPS    ( 2248): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.basicui], name[basicui]
03-28 21:51:40.092+0900 D/APPS    ( 2248): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.basicui]
03-28 21:51:40.092+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [51]
03-28 21:51:40.102+0900 D/DATA_PROVIDER_MASTER( 2273): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-28 21:51:40.102+0900 D/BADGE   ( 2273): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-28 21:51:40.102+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-28 21:51:40.102+0900 E/DATA_PROVIDER_MASTER( 2273): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-28 21:51:40.102+0900 D/COM_CORE( 2248): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2273, fd: -1
03-28 21:51:40.102+0900 D/COM_CORE( 2248): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2273), fd: -1
03-28 21:51:40.102+0900 D/COM_CORE( 2248): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 66 (recv_fd: -1)
03-28 21:51:40.102+0900 D/APPS    ( 2248): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.basicui]
03-28 21:51:40.102+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [54]
03-28 21:51:40.102+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
03-28 21:51:40.102+0900 D/DATA_PROVIDER_MASTER( 2273): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-28 21:51:40.102+0900 D/BADGE   ( 2273): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-28 21:51:40.102+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-28 21:51:40.102+0900 E/DATA_PROVIDER_MASTER( 2273): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-28 21:51:40.102+0900 D/COM_CORE( 2248): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2273, fd: -1
03-28 21:51:40.102+0900 D/COM_CORE( 2248): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2273), fd: -1
03-28 21:51:40.102+0900 D/COM_CORE( 2248): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 66 (recv_fd: -1)
03-28 21:51:40.102+0900 D/APPS    ( 2248): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.basicui], name[basicui]
03-28 21:51:40.102+0900 D/APPS    ( 2248): item.c: item_create(819) >  Icon size after ea_effect (124:127)
03-28 21:51:40.102+0900 D/BADGE   ( 2248): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-28 21:51:40.102+0900 D/APPS    ( 2248): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
03-28 21:51:40.102+0900 D/APPS    ( 2248): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.basicui]'s ordering : 1
03-28 21:51:40.102+0900 D/APPS    ( 2248): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
03-28 21:51:40.112+0900 D/COM_CORE( 2273): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-28 21:51:40.112+0900 D/DATA_PROVIDER_MASTER( 2273): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb9090800 is terminated (NIL packet)
03-28 21:51:40.112+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-28 21:51:40.112+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
03-28 21:51:40.112+0900 D/COM_CORE( 2273): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-28 21:51:40.112+0900 D/DATA_PROVIDER_MASTER( 2273): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb9091288 is terminated (NIL packet)
03-28 21:51:40.112+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-28 21:51:40.112+0900 D/APPS    ( 2248): db.c: apps_db_insert_item(345) >  Insert the item[org.example.basicui:1]
03-28 21:51:40.122+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / install_percent / 100
03-28 21:51:40.122+0900 D/PKGMGR  ( 2276): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-28 21:51:40.122+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.122+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.122+0900 E/PKGMGR_INFO( 2110): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(695) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
03-28 21:51:40.122+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460 / coretpk / org.example.basicui / end / ok
03-28 21:51:40.122+0900 D/PKGMGR  ( 2276): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_1605068460] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-28 21:51:40.122+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.122+0900 D/PKGMGR  ( 2276): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.122+0900 D/PKGMGR  ( 2110): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.122+0900 D/PKGMGR  ( 2110): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.142+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-28 21:51:40.142+0900 D/PKGMGR  ( 2248): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-28 21:51:40.992+0900 D/PKGMGR_SERVER( 3791): pkgmgr-server.c: exit_server(724) > exit_server Start
03-28 21:51:40.992+0900 D/PKGMGR_SERVER( 3791): pkgmgr-server.c: main(1516) > Quit main loop.
03-28 21:51:40.992+0900 D/PKGMGR_SERVER( 3791): pkgmgr-server.c: main(1524) > package manager server terminated.
03-28 21:51:45.192+0900 D/AUL_AMD ( 2162): amd_request.c: __request_handler(495) > __request_handler: 0
03-28 21:51:45.192+0900 D/AUL_AMD ( 2162): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-28 21:51:45.192+0900 D/AUL     ( 2162): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 3857, pid = 3859
03-28 21:51:45.192+0900 D/AUL_AMD ( 2162): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-28 21:51:45.192+0900 D/AUL_AMD ( 2162): amd_launch.c: _start_app(1785) > process_pool: false
03-28 21:51:45.192+0900 D/AUL_AMD ( 2162): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-28 21:51:45.192+0900 D/AUL_AMD ( 2162): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.basicui
03-28 21:51:45.192+0900 D/AUL_AMD ( 2162): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-28 21:51:45.192+0900 D/AUL     ( 2162): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-28 21:51:45.192+0900 D/AUL_PAD ( 2183): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
03-28 21:51:45.192+0900 D/AUL_PAD ( 2183): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-28 21:51:45.192+0900 D/AUL_PAD ( 2183): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 3860 /opt/usr/apps/org.example.basicui/bin/basicui
03-28 21:51:45.192+0900 D/AUL_PAD ( 2183): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-28 21:51:45.192+0900 D/AUL_PAD ( 3860): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-28 21:51:45.192+0900 D/AUL_PAD ( 3860): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-28 21:51:45.192+0900 D/AUL_PAD ( 3860): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
03-28 21:51:45.202+0900 D/AUL_PAD ( 3860): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-28 21:51:45.202+0900 D/AUL_PAD ( 3860): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
03-28 21:51:45.202+0900 D/AUL_PAD ( 3860): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
03-28 21:51:45.202+0900 D/AUL_PAD ( 3860): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
03-28 21:51:45.202+0900 D/LAUNCH  ( 3860): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
03-28 21:51:45.202+0900 I/efl-extension( 3860): efl_extension.c: eext_mod_init(39) > Init
03-28 21:51:45.202+0900 I/CAPI_APPFW_APPLICATION( 3860): app_main.c: ui_app_main(701) > app_efl_main
03-28 21:51:45.202+0900 D/LAUNCH  ( 3860): appcore-efl.c: appcore_efl_main(1571) > [basicui:Application:main:done]
03-28 21:51:45.242+0900 D/APP_CORE( 3860): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-28 21:51:45.242+0900 D/AUL     ( 3860): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 3860 is org.example.basicui
03-28 21:51:45.242+0900 D/APP_CORE( 3860): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.basicui/res/locale
03-28 21:51:45.242+0900 D/APP_CORE( 3860): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-28 21:51:45.242+0900 D/AUL     ( 3860): app_sock.c: __create_server_sock(136) > pg path - already exists
03-28 21:51:45.262+0900 D/LAUNCH  ( 3860): appcore-efl.c: __before_loop(1035) > [basicui:Platform:appcore_init:done]
03-28 21:51:45.262+0900 I/CAPI_APPFW_APPLICATION( 3860): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-28 21:51:45.272+0900 E/EFL     ( 3860): eina_module<3860> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-28 21:51:45.292+0900 E/EFL     ( 3860): ecore_evas<3860> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-28 21:51:45.292+0900 E/EFL     ( 3860): elementary<3860> elc_naviframe.c:46 _nf_mod_init() _nf_mod_init initted 1
03-28 21:51:45.292+0900 E/EFL     ( 3860): eina_module<3860> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so", RTLD_NOW): /opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so: cannot open shared object file: No such file or directory
03-28 21:51:45.302+0900 D/AUL_PAD ( 2183): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-28 21:51:45.302+0900 D/AUL_PAD ( 2183): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-28 21:51:45.302+0900 D/AUL_PAD ( 2183): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-28 21:51:45.302+0900 D/AUL     ( 2162): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-28 21:51:45.302+0900 E/AUL     ( 2162): simple_util.c: __trm_app_info_send_socket(264) > access
03-28 21:51:45.302+0900 D/RESOURCED( 2343): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-28 21:51:45.302+0900 D/RESOURCED( 2343): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2162
03-28 21:51:45.302+0900 D/RESOURCED( 2343): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.basicui, pid 3860, type 4 
03-28 21:51:45.302+0900 D/RESOURCED( 2343): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.basicui, 3860
03-28 21:51:45.302+0900 D/RESOURCED( 2343): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.basicui with pkgname
03-28 21:51:45.302+0900 E/RESOURCED( 2343): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 378
03-28 21:51:45.302+0900 D/RESOURCED( 2343): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-28 21:51:45.342+0900 I/basicui ( 3860): started
03-28 21:51:45.372+0900 W/CRASH_MANAGER( 3715): worker.c: worker_job(1189) > 1103860626173145916950
