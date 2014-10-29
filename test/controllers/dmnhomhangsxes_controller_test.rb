require 'test_helper'

class DmnhomhangsxesControllerTest < ActionController::TestCase
  setup do
    @dmnhomhangsx = dmnhomhangsxes(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmnhomhangsxes)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmnhomhangsx" do
    assert_difference('Dmnhomhangsx.count') do
      post :create, dmnhomhangsx: { stt: @dmnhomhangsx.stt, ten: @dmnhomhangsx.ten }
    end

    assert_redirected_to dmnhomhangsx_path(assigns(:dmnhomhangsx))
  end

  test "should show dmnhomhangsx" do
    get :show, id: @dmnhomhangsx
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmnhomhangsx
    assert_response :success
  end

  test "should update dmnhomhangsx" do
    patch :update, id: @dmnhomhangsx, dmnhomhangsx: { stt: @dmnhomhangsx.stt, ten: @dmnhomhangsx.ten }
    assert_redirected_to dmnhomhangsx_path(assigns(:dmnhomhangsx))
  end

  test "should destroy dmnhomhangsx" do
    assert_difference('Dmnhomhangsx.count', -1) do
      delete :destroy, id: @dmnhomhangsx
    end

    assert_redirected_to dmnhomhangsxes_path
  end
end
