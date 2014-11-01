require 'test_helper'

class DmtinhtrangsControllerTest < ActionController::TestCase
  setup do
    @dmtinhtrang = dmtinhtrangs(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmtinhtrangs)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmtinhtrang" do
    assert_difference('Dmtinhtrang.count') do
      post :create, dmtinhtrang: { stt: @dmtinhtrang.stt, ten: @dmtinhtrang.ten }
    end

    assert_redirected_to dmtinhtrang_path(assigns(:dmtinhtrang))
  end

  test "should show dmtinhtrang" do
    get :show, id: @dmtinhtrang
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmtinhtrang
    assert_response :success
  end

  test "should update dmtinhtrang" do
    patch :update, id: @dmtinhtrang, dmtinhtrang: { stt: @dmtinhtrang.stt, ten: @dmtinhtrang.ten }
    assert_redirected_to dmtinhtrang_path(assigns(:dmtinhtrang))
  end

  test "should destroy dmtinhtrang" do
    assert_difference('Dmtinhtrang.count', -1) do
      delete :destroy, id: @dmtinhtrang
    end

    assert_redirected_to dmtinhtrangs_path
  end
end
