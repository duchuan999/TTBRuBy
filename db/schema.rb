# encoding: UTF-8
# This file is auto-generated from the current state of the database. Instead
# of editing this file, please use the migrations feature of Active Record to
# incrementally modify your database, and then regenerate this schema definition.
#
# Note that this schema.rb definition is the authoritative source for your
# database schema. If you need to create the application database on another
# system, you should be using db:schema:load, not running all the migrations
# from scratch. The latter is a flawed and unsustainable approach (the more migrations
# you'll amass, the slower it'll run and the greater likelihood for issues).
#
# It's strongly recommended that you check this file into your version control system.

ActiveRecord::Schema.define(version: 20141029083626) do

  # These are extensions that must be enabled in order to support this database
  enable_extension "plpgsql"
  enable_extension "edb_dblink_libpq"
  enable_extension "edb_dblink_oci"
  enable_extension "dblink"

  create_table "dmhangsxes", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnhombcs", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnhomhangsxes", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnhomins", force: true do |t|
    t.string   "ten"
    t.integer  "stt"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnhomnhaccs", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnhomnuocsxes", force: true do |t|
    t.string   "ten"
    t.integer  "stt"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnuocsxes", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.integer  "dmnhomnuocsx_id"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  add_index "dmnuocsxes", ["dmnhomnuocsx_id"], name: "index_dmnuocsxes_on_dmnhomnuocsx_id", using: :btree

end
