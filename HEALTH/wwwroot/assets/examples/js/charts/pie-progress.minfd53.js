/*!
 * Remark Material (http://getbootstrapadmin.com/remark)
 * Copyright 2017 amazingsurge
 * Licensed under the Themeforest Standard Licenses
 */

!function(global,factory){if("function"==typeof define&&define.amd)define("/charts/pie-progress",["jquery","Site"],factory);else if("undefined"!=typeof exports)factory(require("jquery"),require("Site"));else{var mod={exports:{}};factory(global.jQuery,global.Site),global.chartsPieProgress=mod.exports}}(this,function(_jquery,_Site){"use strict";var _jquery2=babelHelpers.interopRequireDefault(_jquery),Site=babelHelpers.interopRequireWildcard(_Site);(0,_jquery2.default)(document).ready(function($){Site.run()}),function(){var $example=(0,_jquery2.default)("#examplePieApi");(0,_jquery2.default)(".pie-api-start").on("click",function(){$example.asPieProgress("start")}),(0,_jquery2.default)(".pie-api-finish").on("click",function(){$example.asPieProgress("finish")}),(0,_jquery2.default)(".pie-api-go").on("click",function(){$example.asPieProgress("go",200)}),(0,_jquery2.default)(".pie-api-go_percentage").on("click",function(){$example.asPieProgress("go","50%")}),(0,_jquery2.default)(".pie-api-stop").on("click",function(){$example.asPieProgress("stop")}),(0,_jquery2.default)(".pie-api-reset").on("click",function(){$example.asPieProgress("reset")})}()});